using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMartOLTPUnitTestProject
{
    [TestClass()]
    public class uspAddPhoneNumbers : SqlDatabaseTestClass
    {

        public uspAddPhoneNumbers()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod()]
        public void SinglePhoneEmp()
        {
            SqlDatabaseTestActions testActions = this.SinglePhoneEmpData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void MultiPhoneEmp()
        {
            SqlDatabaseTestActions testActions = this.MultiPhoneEmpData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }


        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SinglePhoneEmp_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SinglePhoneEmp_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckReturnValue;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckCountOfRecords;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckPhoneNumberInserted;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckIsPrimary;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SinglePhoneEmp_PosttestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspAddPhoneNumbers));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneEmp_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneEmp_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneEmp_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckReturnVal;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckFirstPhone;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckFirstIsPri;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckRowCount;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckSecondPhone;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckSecondIsPrimary;
            this.SinglePhoneEmpData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.MultiPhoneEmpData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testCleanupAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            SinglePhoneEmp_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            SinglePhoneEmp_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckReturnValue = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckCountOfRecords = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckPhoneNumberInserted = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckIsPrimary = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            SinglePhoneEmp_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            MultiPhoneEmp_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            MultiPhoneEmp_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            MultiPhoneEmp_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckReturnVal = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckFirstPhone = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckFirstIsPri = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckRowCount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckSecondPhone = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckSecondIsPrimary = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // SinglePhoneEmpData
            // 
            this.SinglePhoneEmpData.PosttestAction = SinglePhoneEmp_PosttestAction;
            this.SinglePhoneEmpData.PretestAction = SinglePhoneEmp_PretestAction;
            this.SinglePhoneEmpData.TestAction = SinglePhoneEmp_TestAction;
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // testCleanupAction
            // 
            resources.ApplyResources(testCleanupAction, "testCleanupAction");
            // 
            // SinglePhoneEmp_PretestAction
            // 
            resources.ApplyResources(SinglePhoneEmp_PretestAction, "SinglePhoneEmp_PretestAction");
            // 
            // SinglePhoneEmp_TestAction
            // 
            SinglePhoneEmp_TestAction.Conditions.Add(CheckReturnValue);
            SinglePhoneEmp_TestAction.Conditions.Add(CheckCountOfRecords);
            SinglePhoneEmp_TestAction.Conditions.Add(CheckPhoneNumberInserted);
            SinglePhoneEmp_TestAction.Conditions.Add(CheckIsPrimary);
            resources.ApplyResources(SinglePhoneEmp_TestAction, "SinglePhoneEmp_TestAction");
            // 
            // CheckReturnValue
            // 
            CheckReturnValue.ColumnNumber = 1;
            CheckReturnValue.Enabled = true;
            CheckReturnValue.ExpectedValue = "0";
            CheckReturnValue.Name = "CheckReturnValue";
            CheckReturnValue.NullExpected = false;
            CheckReturnValue.ResultSet = 1;
            CheckReturnValue.RowNumber = 1;
            // 
            // CheckCountOfRecords
            // 
            CheckCountOfRecords.Enabled = true;
            CheckCountOfRecords.Name = "CheckCountOfRecords";
            CheckCountOfRecords.ResultSet = 2;
            CheckCountOfRecords.RowCount = 1;
            // 
            // CheckPhoneNumberInserted
            // 
            CheckPhoneNumberInserted.ColumnNumber = 1;
            CheckPhoneNumberInserted.Enabled = true;
            CheckPhoneNumberInserted.ExpectedValue = "9130089763";
            CheckPhoneNumberInserted.Name = "CheckPhoneNumberInserted";
            CheckPhoneNumberInserted.NullExpected = false;
            CheckPhoneNumberInserted.ResultSet = 2;
            CheckPhoneNumberInserted.RowNumber = 1;
            // 
            // CheckIsPrimary
            // 
            CheckIsPrimary.ColumnNumber = 2;
            CheckIsPrimary.Enabled = true;
            CheckIsPrimary.ExpectedValue = "1";
            CheckIsPrimary.Name = "CheckIsPrimary";
            CheckIsPrimary.NullExpected = false;
            CheckIsPrimary.ResultSet = 2;
            CheckIsPrimary.RowNumber = 1;
            // 
            // SinglePhoneEmp_PosttestAction
            // 
            resources.ApplyResources(SinglePhoneEmp_PosttestAction, "SinglePhoneEmp_PosttestAction");
            // 
            // MultiPhoneEmpData
            // 
            this.MultiPhoneEmpData.PosttestAction = MultiPhoneEmp_PosttestAction;
            this.MultiPhoneEmpData.PretestAction = MultiPhoneEmp_PretestAction;
            this.MultiPhoneEmpData.TestAction = MultiPhoneEmp_TestAction;
            // 
            // MultiPhoneEmp_TestAction
            // 
            MultiPhoneEmp_TestAction.Conditions.Add(CheckReturnVal);
            MultiPhoneEmp_TestAction.Conditions.Add(CheckFirstPhone);
            MultiPhoneEmp_TestAction.Conditions.Add(CheckFirstIsPri);
            MultiPhoneEmp_TestAction.Conditions.Add(CheckRowCount);
            MultiPhoneEmp_TestAction.Conditions.Add(CheckSecondPhone);
            MultiPhoneEmp_TestAction.Conditions.Add(CheckSecondIsPrimary);
            resources.ApplyResources(MultiPhoneEmp_TestAction, "MultiPhoneEmp_TestAction");
            // 
            // MultiPhoneEmp_PretestAction
            // 
            resources.ApplyResources(MultiPhoneEmp_PretestAction, "MultiPhoneEmp_PretestAction");
            // 
            // MultiPhoneEmp_PosttestAction
            // 
            resources.ApplyResources(MultiPhoneEmp_PosttestAction, "MultiPhoneEmp_PosttestAction");
            // 
            // CheckReturnVal
            // 
            CheckReturnVal.ColumnNumber = 1;
            CheckReturnVal.Enabled = true;
            CheckReturnVal.ExpectedValue = "0";
            CheckReturnVal.Name = "CheckReturnVal";
            CheckReturnVal.NullExpected = false;
            CheckReturnVal.ResultSet = 1;
            CheckReturnVal.RowNumber = 1;
            // 
            // CheckFirstPhone
            // 
            CheckFirstPhone.ColumnNumber = 1;
            CheckFirstPhone.Enabled = true;
            CheckFirstPhone.ExpectedValue = "9130089763";
            CheckFirstPhone.Name = "CheckFirstPhone";
            CheckFirstPhone.NullExpected = false;
            CheckFirstPhone.ResultSet = 2;
            CheckFirstPhone.RowNumber = 1;
            // 
            // CheckFirstIsPri
            // 
            CheckFirstIsPri.ColumnNumber = 2;
            CheckFirstIsPri.Enabled = true;
            CheckFirstIsPri.ExpectedValue = "1";
            CheckFirstIsPri.Name = "CheckFirstIsPri";
            CheckFirstIsPri.NullExpected = false;
            CheckFirstIsPri.ResultSet = 2;
            CheckFirstIsPri.RowNumber = 1;
            // 
            // CheckRowCount
            // 
            CheckRowCount.Enabled = true;
            CheckRowCount.Name = "CheckRowCount";
            CheckRowCount.ResultSet = 2;
            CheckRowCount.RowCount = 2;
            // 
            // CheckSecondPhone
            // 
            CheckSecondPhone.ColumnNumber = 1;
            CheckSecondPhone.Enabled = true;
            CheckSecondPhone.ExpectedValue = "8983879706";
            CheckSecondPhone.Name = "CheckSecondPhone";
            CheckSecondPhone.NullExpected = false;
            CheckSecondPhone.ResultSet = 2;
            CheckSecondPhone.RowNumber = 2;
            // 
            // CheckSecondIsPrimary
            // 
            CheckSecondIsPrimary.ColumnNumber = 2;
            CheckSecondIsPrimary.Enabled = true;
            CheckSecondIsPrimary.ExpectedValue = "0";
            CheckSecondIsPrimary.Name = "CheckSecondIsPrimary";
            CheckSecondIsPrimary.NullExpected = false;
            CheckSecondIsPrimary.ResultSet = 2;
            CheckSecondIsPrimary.RowNumber = 2;
            // 
            // uspAddPhoneNumbers
            // 
            this.TestCleanupAction = testCleanupAction;
            this.TestInitializeAction = testInitializeAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        private SqlDatabaseTestActions SinglePhoneEmpData;
        private SqlDatabaseTestActions MultiPhoneEmpData;
    }
}
