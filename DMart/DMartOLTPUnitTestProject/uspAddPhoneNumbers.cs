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
        [TestMethod(), ExpectedSqlException(MatchFirstError =false, MessageNumber = 50001, Severity =19, State =1)]
        public void ErrorWhenNoPri()
        {
            SqlDatabaseTestActions testActions = this.ErrorWhenNoPriData;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError =false, Severity =19, MessageNumber =50001, State =1)]
        public void ErrorWhenMulPri()
        {
            SqlDatabaseTestActions testActions = this.ErrorWhenMulPriData;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError = false, MessageNumber = 50001, Severity = 19, State = 1)]
        public void ErrorWhenInvPh()
        {
            SqlDatabaseTestActions testActions = this.ErrorWhenInvPhData;
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
        [TestMethod()]
        public void MultiPhoneWIthCd()
        {
            SqlDatabaseTestActions testActions = this.MultiPhoneWIthCdData;
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
        [TestMethod()]
        public void MultiStorPhone()
        {
            SqlDatabaseTestActions testActions = this.MultiStorPhoneData;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspAddPhoneNumbers));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SinglePhoneEmp_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SinglePhoneEmp_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckReturnValue;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckCountOfRecords;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckPhoneNumberInserted;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckIsPrimary;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SinglePhoneEmp_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneEmp_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckReturnVal;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckFirstPhone;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckFirstIsPri;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckRowCount;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckSecondPhone;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckSecondIsPrimary;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneEmp_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneEmp_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenNoPri_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenNoPri_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenNoPri_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenMulPri_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenMulPri_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenMulPri_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenInvPh_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenInvPh_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ErrorWhenInvPh_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneWIthCd_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckRCValue;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckRowCnt;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckPhNum;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckIsPri;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckSecPh;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckSecIsPri;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneWIthCd_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiPhoneWIthCd_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiStorPhone_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiStorPhone_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckStRC;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckSecondRCSt;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckFirstNumSt;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckFirstIsPriSt;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckSecPhSt;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckIsPriSecSt;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MultiStorPhone_PosttestAction;
            this.SinglePhoneEmpData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.MultiPhoneEmpData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ErrorWhenNoPriData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ErrorWhenMulPriData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ErrorWhenInvPhData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.MultiPhoneWIthCdData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.MultiStorPhoneData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
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
            CheckReturnVal = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckFirstPhone = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckFirstIsPri = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckRowCount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckSecondPhone = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckSecondIsPrimary = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            MultiPhoneEmp_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            MultiPhoneEmp_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ErrorWhenNoPri_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ErrorWhenNoPri_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ErrorWhenNoPri_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ErrorWhenMulPri_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            ErrorWhenMulPri_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ErrorWhenMulPri_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ErrorWhenInvPh_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ErrorWhenInvPh_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ErrorWhenInvPh_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            MultiPhoneWIthCd_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckRCValue = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckRowCnt = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckPhNum = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckIsPri = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckSecPh = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckSecIsPri = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            MultiPhoneWIthCd_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            MultiPhoneWIthCd_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            MultiStorPhone_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            MultiStorPhone_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckStRC = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckSecondRCSt = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckFirstNumSt = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckFirstIsPriSt = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckSecPhSt = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckIsPriSecSt = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            MultiStorPhone_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
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
            // MultiPhoneEmp_PretestAction
            // 
            resources.ApplyResources(MultiPhoneEmp_PretestAction, "MultiPhoneEmp_PretestAction");
            // 
            // MultiPhoneEmp_PosttestAction
            // 
            resources.ApplyResources(MultiPhoneEmp_PosttestAction, "MultiPhoneEmp_PosttestAction");
            // 
            // ErrorWhenNoPri_TestAction
            // 
            resources.ApplyResources(ErrorWhenNoPri_TestAction, "ErrorWhenNoPri_TestAction");
            // 
            // ErrorWhenNoPri_PretestAction
            // 
            resources.ApplyResources(ErrorWhenNoPri_PretestAction, "ErrorWhenNoPri_PretestAction");
            // 
            // ErrorWhenNoPri_PosttestAction
            // 
            resources.ApplyResources(ErrorWhenNoPri_PosttestAction, "ErrorWhenNoPri_PosttestAction");
            // 
            // ErrorWhenMulPri_TestAction
            // 
            ErrorWhenMulPri_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(ErrorWhenMulPri_TestAction, "ErrorWhenMulPri_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // ErrorWhenMulPri_PretestAction
            // 
            resources.ApplyResources(ErrorWhenMulPri_PretestAction, "ErrorWhenMulPri_PretestAction");
            // 
            // ErrorWhenMulPri_PosttestAction
            // 
            resources.ApplyResources(ErrorWhenMulPri_PosttestAction, "ErrorWhenMulPri_PosttestAction");
            // 
            // ErrorWhenInvPh_TestAction
            // 
            resources.ApplyResources(ErrorWhenInvPh_TestAction, "ErrorWhenInvPh_TestAction");
            // 
            // ErrorWhenInvPh_PretestAction
            // 
            resources.ApplyResources(ErrorWhenInvPh_PretestAction, "ErrorWhenInvPh_PretestAction");
            // 
            // ErrorWhenInvPh_PosttestAction
            // 
            resources.ApplyResources(ErrorWhenInvPh_PosttestAction, "ErrorWhenInvPh_PosttestAction");
            // 
            // MultiPhoneWIthCd_TestAction
            // 
            MultiPhoneWIthCd_TestAction.Conditions.Add(CheckRCValue);
            MultiPhoneWIthCd_TestAction.Conditions.Add(CheckRowCnt);
            MultiPhoneWIthCd_TestAction.Conditions.Add(CheckPhNum);
            MultiPhoneWIthCd_TestAction.Conditions.Add(CheckIsPri);
            MultiPhoneWIthCd_TestAction.Conditions.Add(CheckSecPh);
            MultiPhoneWIthCd_TestAction.Conditions.Add(CheckSecIsPri);
            resources.ApplyResources(MultiPhoneWIthCd_TestAction, "MultiPhoneWIthCd_TestAction");
            // 
            // CheckRCValue
            // 
            CheckRCValue.ColumnNumber = 1;
            CheckRCValue.Enabled = true;
            CheckRCValue.ExpectedValue = "0";
            CheckRCValue.Name = "CheckRCValue";
            CheckRCValue.NullExpected = false;
            CheckRCValue.ResultSet = 1;
            CheckRCValue.RowNumber = 1;
            // 
            // CheckRowCnt
            // 
            CheckRowCnt.Enabled = true;
            CheckRowCnt.Name = "CheckRowCnt";
            CheckRowCnt.ResultSet = 2;
            CheckRowCnt.RowCount = 2;
            // 
            // CheckPhNum
            // 
            CheckPhNum.ColumnNumber = 1;
            CheckPhNum.Enabled = true;
            CheckPhNum.ExpectedValue = "+919130089763";
            CheckPhNum.Name = "CheckPhNum";
            CheckPhNum.NullExpected = false;
            CheckPhNum.ResultSet = 2;
            CheckPhNum.RowNumber = 1;
            // 
            // CheckIsPri
            // 
            CheckIsPri.ColumnNumber = 2;
            CheckIsPri.Enabled = true;
            CheckIsPri.ExpectedValue = "1";
            CheckIsPri.Name = "CheckIsPri";
            CheckIsPri.NullExpected = false;
            CheckIsPri.ResultSet = 2;
            CheckIsPri.RowNumber = 1;
            // 
            // CheckSecPh
            // 
            CheckSecPh.ColumnNumber = 1;
            CheckSecPh.Enabled = true;
            CheckSecPh.ExpectedValue = "+918983879706";
            CheckSecPh.Name = "CheckSecPh";
            CheckSecPh.NullExpected = false;
            CheckSecPh.ResultSet = 2;
            CheckSecPh.RowNumber = 2;
            // 
            // CheckSecIsPri
            // 
            CheckSecIsPri.ColumnNumber = 2;
            CheckSecIsPri.Enabled = true;
            CheckSecIsPri.ExpectedValue = "0";
            CheckSecIsPri.Name = "CheckSecIsPri";
            CheckSecIsPri.NullExpected = false;
            CheckSecIsPri.ResultSet = 2;
            CheckSecIsPri.RowNumber = 2;
            // 
            // MultiPhoneWIthCd_PretestAction
            // 
            resources.ApplyResources(MultiPhoneWIthCd_PretestAction, "MultiPhoneWIthCd_PretestAction");
            // 
            // MultiPhoneWIthCd_PosttestAction
            // 
            resources.ApplyResources(MultiPhoneWIthCd_PosttestAction, "MultiPhoneWIthCd_PosttestAction");
            // 
            // MultiStorPhone_TestAction
            // 
            MultiStorPhone_TestAction.Conditions.Add(CheckStRC);
            MultiStorPhone_TestAction.Conditions.Add(CheckSecondRCSt);
            MultiStorPhone_TestAction.Conditions.Add(CheckFirstNumSt);
            MultiStorPhone_TestAction.Conditions.Add(CheckFirstIsPriSt);
            MultiStorPhone_TestAction.Conditions.Add(CheckSecPhSt);
            MultiStorPhone_TestAction.Conditions.Add(CheckIsPriSecSt);
            resources.ApplyResources(MultiStorPhone_TestAction, "MultiStorPhone_TestAction");
            // 
            // MultiStorPhone_PretestAction
            // 
            resources.ApplyResources(MultiStorPhone_PretestAction, "MultiStorPhone_PretestAction");
            // 
            // SinglePhoneEmpData
            // 
            this.SinglePhoneEmpData.PosttestAction = SinglePhoneEmp_PosttestAction;
            this.SinglePhoneEmpData.PretestAction = SinglePhoneEmp_PretestAction;
            this.SinglePhoneEmpData.TestAction = SinglePhoneEmp_TestAction;
            // 
            // MultiPhoneEmpData
            // 
            this.MultiPhoneEmpData.PosttestAction = MultiPhoneEmp_PosttestAction;
            this.MultiPhoneEmpData.PretestAction = MultiPhoneEmp_PretestAction;
            this.MultiPhoneEmpData.TestAction = MultiPhoneEmp_TestAction;
            // 
            // ErrorWhenNoPriData
            // 
            this.ErrorWhenNoPriData.PosttestAction = ErrorWhenNoPri_PosttestAction;
            this.ErrorWhenNoPriData.PretestAction = ErrorWhenNoPri_PretestAction;
            this.ErrorWhenNoPriData.TestAction = ErrorWhenNoPri_TestAction;
            // 
            // ErrorWhenMulPriData
            // 
            this.ErrorWhenMulPriData.PosttestAction = ErrorWhenMulPri_PosttestAction;
            this.ErrorWhenMulPriData.PretestAction = ErrorWhenMulPri_PretestAction;
            this.ErrorWhenMulPriData.TestAction = ErrorWhenMulPri_TestAction;
            // 
            // ErrorWhenInvPhData
            // 
            this.ErrorWhenInvPhData.PosttestAction = ErrorWhenInvPh_PosttestAction;
            this.ErrorWhenInvPhData.PretestAction = ErrorWhenInvPh_PretestAction;
            this.ErrorWhenInvPhData.TestAction = ErrorWhenInvPh_TestAction;
            // 
            // MultiPhoneWIthCdData
            // 
            this.MultiPhoneWIthCdData.PosttestAction = MultiPhoneWIthCd_PosttestAction;
            this.MultiPhoneWIthCdData.PretestAction = MultiPhoneWIthCd_PretestAction;
            this.MultiPhoneWIthCdData.TestAction = MultiPhoneWIthCd_TestAction;
            // 
            // MultiStorPhoneData
            // 
            this.MultiStorPhoneData.PosttestAction = MultiStorPhone_PosttestAction;
            this.MultiStorPhoneData.PretestAction = MultiStorPhone_PretestAction;
            this.MultiStorPhoneData.TestAction = MultiStorPhone_TestAction;
            // 
            // CheckStRC
            // 
            CheckStRC.ColumnNumber = 1;
            CheckStRC.Enabled = true;
            CheckStRC.ExpectedValue = "0";
            CheckStRC.Name = "CheckStRC";
            CheckStRC.NullExpected = false;
            CheckStRC.ResultSet = 1;
            CheckStRC.RowNumber = 1;
            // 
            // CheckSecondRCSt
            // 
            CheckSecondRCSt.Enabled = true;
            CheckSecondRCSt.Name = "CheckSecondRCSt";
            CheckSecondRCSt.ResultSet = 2;
            CheckSecondRCSt.RowCount = 2;
            // 
            // CheckFirstNumSt
            // 
            CheckFirstNumSt.ColumnNumber = 1;
            CheckFirstNumSt.Enabled = true;
            CheckFirstNumSt.ExpectedValue = "+919130089763";
            CheckFirstNumSt.Name = "CheckFirstNumSt";
            CheckFirstNumSt.NullExpected = false;
            CheckFirstNumSt.ResultSet = 2;
            CheckFirstNumSt.RowNumber = 1;
            // 
            // CheckFirstIsPriSt
            // 
            CheckFirstIsPriSt.ColumnNumber = 2;
            CheckFirstIsPriSt.Enabled = true;
            CheckFirstIsPriSt.ExpectedValue = "1";
            CheckFirstIsPriSt.Name = "CheckFirstIsPriSt";
            CheckFirstIsPriSt.NullExpected = false;
            CheckFirstIsPriSt.ResultSet = 2;
            CheckFirstIsPriSt.RowNumber = 1;
            // 
            // CheckSecPhSt
            // 
            CheckSecPhSt.ColumnNumber = 1;
            CheckSecPhSt.Enabled = true;
            CheckSecPhSt.ExpectedValue = "+918983879706";
            CheckSecPhSt.Name = "CheckSecPhSt";
            CheckSecPhSt.NullExpected = false;
            CheckSecPhSt.ResultSet = 2;
            CheckSecPhSt.RowNumber = 2;
            // 
            // CheckIsPriSecSt
            // 
            CheckIsPriSecSt.ColumnNumber = 2;
            CheckIsPriSecSt.Enabled = true;
            CheckIsPriSecSt.ExpectedValue = "0";
            CheckIsPriSecSt.Name = "CheckIsPriSecSt";
            CheckIsPriSecSt.NullExpected = false;
            CheckIsPriSecSt.ResultSet = 2;
            CheckIsPriSecSt.RowNumber = 2;
            // 
            // MultiStorPhone_PosttestAction
            // 
            resources.ApplyResources(MultiStorPhone_PosttestAction, "MultiStorPhone_PosttestAction");
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
        private SqlDatabaseTestActions ErrorWhenNoPriData;
        private SqlDatabaseTestActions ErrorWhenMulPriData;
        private SqlDatabaseTestActions ErrorWhenInvPhData;
        private SqlDatabaseTestActions MultiPhoneWIthCdData;
        private SqlDatabaseTestActions MultiStorPhoneData;
    }
}
