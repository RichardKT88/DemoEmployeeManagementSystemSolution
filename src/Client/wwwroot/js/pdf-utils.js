window.pdfUtils = {
    generateEmployeePdf: function (employeesJson) {
        const employees = JSON.parse(employeesJson);

        const body = [
            ['Civil ID', 'File Number', 'Name', 'Telephone', 'Job Name', 'Branch', 'Town']
        ];

        employees.forEach(emp => {
            body.push([
                emp.civilId,
                emp.fileNumber,
                emp.name,
                emp.telephoneNumber,
                emp.jobName,
                emp.branch.name,
                emp.town.name
            ]);
        });

        const docDefinition = {
            content: [
                { text: 'Employees List', style: 'header' },
                {
                    table: {
                        headerRows: 1,
                        widths: ['auto', 'auto', '*', 'auto', '*', '*', '*'],
                        body: body
                    }
                }
            ],
            styles: {
                header: { fontSize: 18, bold: true, margin: [0, 0, 0, 10] }
            }
        };

        pdfMake.createPdf(docDefinition).open();
    },
    generateDoctorPdf: function (doctorJson) {
        const doctors = JSON.parse(doctorJson);

        const body = [
            ['ID', 'Medical Diagnose', 'Recommendation', 'Date']
        ];

        doctors.forEach(doc => {
            body.push([
                doc.employeeId,
                doc.medicalDiagnose,
                doc.medicalRecommendation,
                doc.date,

            ]);
        });

        const docDefinition = {
            content: [
                { text: 'Doctor List', style: 'header' },
                {
                    table: {
                        headerRows: 1,
                        widths: ['auto', 'auto', 'auto', 'auto'],
                        body: body
                    }
                }
            ],
            styles: {
                header: { fontSize: 18, bold: true, margin: [0, 0, 0, 10] }
            }
        };

        pdfMake.createPdf(docDefinition).open();
    }
};
window.printGrid = () => {
    window.print();
};
