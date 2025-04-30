window.excelUtils = {
    exportToExcel: function (employeesJson) {
        const employees = JSON.parse(employeesJson);

        // Converte a lista de objetos diretamente para uma planilha
        const worksheet = XLSX.utils.json_to_sheet(employees.map(emp => ({
            "Civil ID": emp.CivilId,
            "File Number": emp.FileNumber,
            "Name": emp.Name,
            "Telephone": emp.TelephoneNumber,
            "Job Name": emp.JobName,
            "Branch": emp.Branch?.Name || '',
            "Town": emp.Town?.Name || ''
        })));

        const workbook = XLSX.utils.book_new();
        XLSX.utils.book_append_sheet(workbook, worksheet, "Employees");

        XLSX.writeFile(workbook, "employees.xlsx");
    }
};