namespace Client.ApplicationStates
{
    public class AllState
    {
        //Scope action
        public Action? Action { get; set; }

        //General Department
        public bool ShowGeneralDepartment { get; set; }
        public void GeneralDepartmentClicked() 
        {
            ResetAll();
            ShowGeneralDepartment = true;
            Action?.Invoke();
        }

        //Department
        public bool ShowDepartment { get; set; }
        public void DepartmentClicked()
        {
            ResetAll();
            ShowDepartment = true;
            Action?.Invoke();
        }

        //Branch
        public bool ShowBranch { get; set; }
        public void BranchClicked()
        {
            ResetAll();
            ShowBranch = true;
            Action?.Invoke();
        }

        //Country
        public bool ShowCountry { get; set; }
        public void CountryClicked()
        {
            ResetAll();
            ShowCountry = true;
            Action?.Invoke();
        }

        //Town
        public bool ShowTown { get; set; }
        public void TownClicked()
        {
            ResetAll();
            ShowTown = true;
            Action?.Invoke();
        }

        //City
        public bool ShowCity { get; set; }
        public void CityClicked()
        {
            ResetAll();
            ShowCity = true;
            Action?.Invoke();
        }

        //User
        public bool ShowUser { get; set; }
        public void UserClicked()
        {
            ResetAll();
            ShowUser = true;
            Action?.Invoke();
        }
        //Employee
        public bool ShowEmployee { get; set; } = true;
        public void EmployeeClicked()
        {
            ResetAll();
            ShowEmployee = true;
            Action?.Invoke();
        }

        //Doctor
        public bool ShowHealth { get; set; }
        public void HealthClicked()
        {
            ResetAll();
            ShowHealth = true;
            Action?.Invoke();
        }

        //Overtime
        public bool ShowOvertime { get; set; }
        public void OvertimeClicked()
        {
            ResetAll();
            ShowOvertime = true;
            Action?.Invoke();
        }

        //Overtime Type
        public bool ShowOvertimeType { get; set; }
        public void OvertimeTypeClicked()
        {
            ResetAll();
            ShowOvertimeType = true;
            Action?.Invoke();
        }

        //Sanction
        public bool ShowSanction { get; set; }
        public void SanctionClicked()
        {
            ResetAll();
            ShowSanction = true;
            Action?.Invoke();
        }

        //Sanction Type
        public bool ShowSanctionType { get; set; }
        public void SanctionTypeClicked()
        {
            ResetAll();
            ShowSanctionType = true;
            Action?.Invoke();
        }

        //Vacation
        public bool ShowVacation { get; set; }
        public void VacationClicked()
        {
            ResetAll();
            ShowVacation = true;
            Action?.Invoke();
        }

        //Vacation Type
        public bool ShowVacationType { get; set; }
        public void VacationTypeClicked()
        {
            ResetAll();
            ShowVacationType = true;
            Action?.Invoke();
        }
        private void ResetAll()
        {
            ShowGeneralDepartment = false;
            ShowDepartment = false;
            ShowBranch = false;
            ShowCountry = false;
            ShowCity = false;
            ShowTown = false;
            ShowUser = false;
            ShowEmployee = false;
            ShowHealth = false;
            ShowOvertime = false;
            ShowOvertimeType = false;
            ShowSanction = false;
            ShowSanctionType = false;
            ShowVacation = false;
            ShowVacationType = false;
        }
    }
}
