(function ($) {
    var binded;

    $(document).ready(function () {
        $(".collapsible").collapsible();
    });

    $(".datepicker").pickadate({
        selectMonths: true,
        selectYears: 2
    });

    $(window).resize(function () {
        binded();
    });

    $("[data-group-id]").on("click",
        function (event) {
            var url = "/Statistic/GetGroupStatistic";

            event.preventDefault();

            var groupId = $(this).attr("data-group-id");
            var dateFrom = $("[data-is-date-from]").val();
            var dateTo = $("[data-is-date-to]").val();
            var groupName = $(this).text();
            var search = $("#search");

            search.val(groupName);

            $.get(url,
                {
                    groupId: groupId,
                    from: dateFrom,
                    to: dateTo
                })
                .done(function (response) {
                    $('.collapsible').collapsible('close', 0);

                    google.charts.load("current", { "packages": ["corechart"] });

                    var dailyOccupations = [];
                    response.dailyOccupations.forEach(function (item) {
                        var pair = [];

                        var regex = /(\d{4}-\d{2}-\d{2}).*/;
                        pair.push(item.date.replace(regex, "$1"));
                        pair.push(item.eventsCount);                                           

                        dailyOccupations.push(pair);
                    });

                    var eventTypeCounts = [];
                    response.eventTypeCounts.forEach(function (item) {
                        var pair = [];
                        pair.push(item.type);
                        pair.push(item.count);

                        eventTypeCounts.push(pair);
                    });

                    var context = {
                        dailyOccupations: dailyOccupations,
                        eventTypeCounts: eventTypeCounts
                    };
                    binded = setOnLoadCallbackFunction.bind(context);
                    google.charts.setOnLoadCallback(binded);

                    function setOnLoadCallbackFunction() {
                        var dailyOccupationsContainerId = "daily-occupations-container";
                        var eventTypeCountsContainerId = "event-type-counts-container";

                        drawDailyOccupationsChart(this.dailyOccupations, dailyOccupationsContainerId);
                        drawEventTypeCountsChart(this.eventTypeCounts, eventTypeCountsContainerId);
                    }
                });
        });

    function drawDailyOccupationsChart(dailyOccupations, chartContainerId) {
        var dataTable = new google.visualization.DataTable();
        dataTable.addColumn("string", "Date");
        dataTable.addColumn("number", "Events");
        dataTable.addRows(dailyOccupations);

        var options = {
            "title": "Events Count For Period"
        };

        var chartContainer = document.getElementById(chartContainerId);
        var chart = new google.visualization.AreaChart(chartContainer);
        chart.draw(dataTable, options);
    }

    function drawEventTypeCountsChart(eventTypeCounts, chartContainerId) {
        var dataTable = new google.visualization.DataTable();
        dataTable.addColumn("string", "Event Type");
        dataTable.addColumn("number", "Count");
        dataTable.addRows(eventTypeCounts);

        var options = {
            "title": "Events Types Counts"
        };

        var chartContainer = document.getElementById(chartContainerId);
        var chart = new google.visualization.PieChart(chartContainer);
        chart.draw(dataTable, options);
    }
})(jQuery);