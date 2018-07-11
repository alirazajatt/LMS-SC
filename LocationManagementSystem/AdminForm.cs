using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnUpdateLocations_Click(object sender, EventArgs e)
        {
            UpdateLocationsForm locationForm = new UpdateLocationsForm();

            locationForm.ShowDialog(this);
        }

        private void btnUpdateDepartments_Click(object sender, EventArgs e)
        {
            UpdateDepartmentForm departmentForm = new UpdateDepartmentForm();

            departmentForm.ShowDialog(this);
        }

        private void btnUpdateSections_Click(object sender, EventArgs e)
        {
            UpdateSectionForm sectionsForm = new UpdateSectionForm();

            sectionsForm.ShowDialog(this);
        }

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            UpdateCompanyNameForm companyForm = new UpdateCompanyNameForm();

            companyForm.ShowDialog(this);
        }

        private void btnUpdateDesgination_Click(object sender, EventArgs e)
        {
            UpdateDesignationForm designationForm = new UpdateDesignationForm();

            designationForm.ShowDialog(this);
        }

        private void btnUpdateCadre_Click(object sender, EventArgs e)
        {
            UpdateCadreForm cadreForm = new UpdateCadreForm();

            cadreForm.ShowDialog(this);
        }

        private void btnEmails_Click(object sender, EventArgs e)
        {
            AddEmailAddressForm emailAddressForm = new AddEmailAddressForm();

            emailAddressForm.ShowDialog(this);
        }

        private void btnSystemSettings_Click(object sender, EventArgs e)
        {
            SystemSetting setting = EFERTDbUtility.mEFERTDb.SystemSetting.FirstOrDefault();

            SetSystemSettingForm systemSettingForm = new SetSystemSettingForm(setting);

            systemSettingForm.ShowDialog(this);
        }
    }
}
