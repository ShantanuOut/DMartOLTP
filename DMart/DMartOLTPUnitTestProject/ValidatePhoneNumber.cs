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
    public class Stores : SqlDatabaseTestClass
    {

        public Stores()
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

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction PhoneNumberShort_Valid_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stores));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction PhoneNumberLong_valid_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction PhoneNumberShortAplha_invalid_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction PhoneNumberShortSymbol_invalid_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction PhoneNumberLongSymbol_invalid_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction LessThanTen_invalid_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MoreThanThirteen_invalid_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ThirteenDigitsWithoutPlus_invalid_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition8;
            this.PhoneNumberShort_ValidData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.PhoneNumberLong_validData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.PhoneNumberShortAplha_invalidData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.PhoneNumberShortSymbol_invalidData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.PhoneNumberLongSymbol_invalidData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.LessThanTen_invalidData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.MoreThanThirteen_invalidData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ThirteenDigitsWithoutPlus_invalidData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            PhoneNumberShort_Valid_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            PhoneNumberLong_valid_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            PhoneNumberShortAplha_invalid_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            PhoneNumberShortSymbol_invalid_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            PhoneNumberLongSymbol_invalid_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            LessThanTen_invalid_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            MoreThanThirteen_invalid_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ThirteenDigitsWithoutPlus_invalid_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // PhoneNumberShort_Valid_TestAction
            // 
            PhoneNumberShort_Valid_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(PhoneNumberShort_Valid_TestAction, "PhoneNumberShort_Valid_TestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = null;
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = true;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // PhoneNumberLong_valid_TestAction
            // 
            PhoneNumberLong_valid_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(PhoneNumberLong_valid_TestAction, "PhoneNumberLong_valid_TestAction");
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = null;
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = true;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // PhoneNumberShortAplha_invalid_TestAction
            // 
            PhoneNumberShortAplha_invalid_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(PhoneNumberShortAplha_invalid_TestAction, "PhoneNumberShortAplha_invalid_TestAction");
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 1;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = null;
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = true;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
            // 
            // PhoneNumberShortSymbol_invalid_TestAction
            // 
            PhoneNumberShortSymbol_invalid_TestAction.Conditions.Add(scalarValueCondition4);
            resources.ApplyResources(PhoneNumberShortSymbol_invalid_TestAction, "PhoneNumberShortSymbol_invalid_TestAction");
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 1;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = null;
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = true;
            scalarValueCondition4.ResultSet = 1;
            scalarValueCondition4.RowNumber = 1;
            // 
            // PhoneNumberLongSymbol_invalid_TestAction
            // 
            PhoneNumberLongSymbol_invalid_TestAction.Conditions.Add(scalarValueCondition5);
            resources.ApplyResources(PhoneNumberLongSymbol_invalid_TestAction, "PhoneNumberLongSymbol_invalid_TestAction");
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 1;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = null;
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = true;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // LessThanTen_invalid_TestAction
            // 
            LessThanTen_invalid_TestAction.Conditions.Add(scalarValueCondition6);
            resources.ApplyResources(LessThanTen_invalid_TestAction, "LessThanTen_invalid_TestAction");
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 1;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = null;
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = true;
            scalarValueCondition6.ResultSet = 1;
            scalarValueCondition6.RowNumber = 1;
            // 
            // MoreThanThirteen_invalid_TestAction
            // 
            MoreThanThirteen_invalid_TestAction.Conditions.Add(scalarValueCondition7);
            resources.ApplyResources(MoreThanThirteen_invalid_TestAction, "MoreThanThirteen_invalid_TestAction");
            // 
            // scalarValueCondition7
            // 
            scalarValueCondition7.ColumnNumber = 1;
            scalarValueCondition7.Enabled = true;
            scalarValueCondition7.ExpectedValue = null;
            scalarValueCondition7.Name = "scalarValueCondition7";
            scalarValueCondition7.NullExpected = true;
            scalarValueCondition7.ResultSet = 1;
            scalarValueCondition7.RowNumber = 1;
            // 
            // PhoneNumberShort_ValidData
            // 
            this.PhoneNumberShort_ValidData.PosttestAction = null;
            this.PhoneNumberShort_ValidData.PretestAction = null;
            this.PhoneNumberShort_ValidData.TestAction = PhoneNumberShort_Valid_TestAction;
            // 
            // PhoneNumberLong_validData
            // 
            this.PhoneNumberLong_validData.PosttestAction = null;
            this.PhoneNumberLong_validData.PretestAction = null;
            this.PhoneNumberLong_validData.TestAction = PhoneNumberLong_valid_TestAction;
            // 
            // PhoneNumberShortAplha_invalidData
            // 
            this.PhoneNumberShortAplha_invalidData.PosttestAction = null;
            this.PhoneNumberShortAplha_invalidData.PretestAction = null;
            this.PhoneNumberShortAplha_invalidData.TestAction = PhoneNumberShortAplha_invalid_TestAction;
            // 
            // PhoneNumberShortSymbol_invalidData
            // 
            this.PhoneNumberShortSymbol_invalidData.PosttestAction = null;
            this.PhoneNumberShortSymbol_invalidData.PretestAction = null;
            this.PhoneNumberShortSymbol_invalidData.TestAction = PhoneNumberShortSymbol_invalid_TestAction;
            // 
            // PhoneNumberLongSymbol_invalidData
            // 
            this.PhoneNumberLongSymbol_invalidData.PosttestAction = null;
            this.PhoneNumberLongSymbol_invalidData.PretestAction = null;
            this.PhoneNumberLongSymbol_invalidData.TestAction = PhoneNumberLongSymbol_invalid_TestAction;
            // 
            // LessThanTen_invalidData
            // 
            this.LessThanTen_invalidData.PosttestAction = null;
            this.LessThanTen_invalidData.PretestAction = null;
            this.LessThanTen_invalidData.TestAction = LessThanTen_invalid_TestAction;
            // 
            // MoreThanThirteen_invalidData
            // 
            this.MoreThanThirteen_invalidData.PosttestAction = null;
            this.MoreThanThirteen_invalidData.PretestAction = null;
            this.MoreThanThirteen_invalidData.TestAction = MoreThanThirteen_invalid_TestAction;
            // 
            // ThirteenDigitsWithoutPlus_invalidData
            // 
            this.ThirteenDigitsWithoutPlus_invalidData.PosttestAction = null;
            this.ThirteenDigitsWithoutPlus_invalidData.PretestAction = null;
            this.ThirteenDigitsWithoutPlus_invalidData.TestAction = ThirteenDigitsWithoutPlus_invalid_TestAction;
            // 
            // ThirteenDigitsWithoutPlus_invalid_TestAction
            // 
            ThirteenDigitsWithoutPlus_invalid_TestAction.Conditions.Add(scalarValueCondition8);
            resources.ApplyResources(ThirteenDigitsWithoutPlus_invalid_TestAction, "ThirteenDigitsWithoutPlus_invalid_TestAction");
            // 
            // scalarValueCondition8
            // 
            scalarValueCondition8.ColumnNumber = 1;
            scalarValueCondition8.Enabled = true;
            scalarValueCondition8.ExpectedValue = null;
            scalarValueCondition8.Name = "scalarValueCondition8";
            scalarValueCondition8.NullExpected = true;
            scalarValueCondition8.ResultSet = 1;
            scalarValueCondition8.RowNumber = 1;
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

        [TestMethod()]
        public void PhoneNumberShort_Valid()
        {
            SqlDatabaseTestActions testActions = this.PhoneNumberShort_ValidData;
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
        public void PhoneNumberLong_valid()
        {
            SqlDatabaseTestActions testActions = this.PhoneNumberLong_validData;
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
        public void PhoneNumberShortAplha_invalid()
        {
            SqlDatabaseTestActions testActions = this.PhoneNumberShortAplha_invalidData;
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
        public void PhoneNumberShortSymbol_invalid()
        {
            SqlDatabaseTestActions testActions = this.PhoneNumberShortSymbol_invalidData;
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
        public void PhoneNumberLongSymbol_invalid()
        {
            SqlDatabaseTestActions testActions = this.PhoneNumberLongSymbol_invalidData;
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
        public void LessThanTen_invalid()
        {
            SqlDatabaseTestActions testActions = this.LessThanTen_invalidData;
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
        public void MoreThanThirteen_invalid()
        {
            SqlDatabaseTestActions testActions = this.MoreThanThirteen_invalidData;
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
        public void ThirteenDigitsWithoutPlus_invalid()
        {
            SqlDatabaseTestActions testActions = this.ThirteenDigitsWithoutPlus_invalidData;
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







        private SqlDatabaseTestActions PhoneNumberShort_ValidData;
        private SqlDatabaseTestActions PhoneNumberLong_validData;
        private SqlDatabaseTestActions PhoneNumberShortAplha_invalidData;
        private SqlDatabaseTestActions PhoneNumberShortSymbol_invalidData;
        private SqlDatabaseTestActions PhoneNumberLongSymbol_invalidData;
        private SqlDatabaseTestActions LessThanTen_invalidData;
        private SqlDatabaseTestActions MoreThanThirteen_invalidData;
        private SqlDatabaseTestActions ThirteenDigitsWithoutPlus_invalidData;
    }
}
