///Document ready
$(document).ready(function () {

    $("#employeeForm").submit(function (e) {
        e.preventDefault();
        search($("#Employee").val());
    });

    //$("#btnSearch").bind("click", function (e) {
    //    var form = $("employeeForm");
    //    form.stopPropagation();
    //    form.preventDefault();
    //    search($("#Employee").val());
    //});

    search($("#Employee").val());
});

///Gets an employee or a list of employees
function search(Id) {
    var data = { Id: Id };
    $.post(url, data).done(function (d) {
        console.log(d);
        var htmlContent = "";
        $('#ContenidoTabla').html("");
        if (d.length > 1) {
            $.each(d, function (i, e) {
                GetRowsEmployee(e);
            });
        } else {
            GetRowsEmployee(d);
        }
        
    }).fail().always(function () { });
}

///Gets an employee html row
function GetRowsEmployee(e) {
    var htmlContent = "";
    htmlContent += "<tr>";
    htmlContent += "<th scope='row'>" + e.Id + "</td>";
    htmlContent += "<td>" + e.Name + "</td>";
    htmlContent += "<td>" + e.ContractType.Name + "</td >";
    htmlContent += "<td>" + e.Role.Name + "</td>";
    htmlContent += "<td>" + e.Role.HourlySalary + "</td>";
    htmlContent += "<td>" + e.Role.MonthlySalary + "</td >";
    htmlContent += "<td>" + e.Salary + "</td>";
    htmlContent += "</tr>";
    $('#ContenidoTabla').append(htmlContent);
}