(function($) {
    $(document).ready(function () {
        $(".collapsible").collapsible();
    });

    $(".datepicker").pickadate({
        selectMonths: true,
        selectYears: 2
    });

    $("[data-teacher-id]").on("click",
        function (event) {
            event.preventDefault();

            var url = "/Statistic/GetTeacherStatistic";
            var teacherId = $(this).attr("data-teacher-id");
            var dateFrom = $("[data-is-date-from]").val();
            var dateTo = $("[data-is-date-to]").val();
            var teacherFullName = $(this).parent().attr("title");
            var search = $("#search");

            search.val(teacherFullName);

            $.get(url,
            {
                teacherId: teacherId,
                from: dateFrom,
                to: dateTo
            });
        });
})(jQuery);