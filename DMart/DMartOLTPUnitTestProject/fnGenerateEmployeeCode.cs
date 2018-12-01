using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Transactions;

namespace DMartOLTPUnitTestProject
{
    [TestClass()]
    public class fnGenerateEmployeeCode : SqlDatabaseTestClass
    {

        public fnGenerateEmployeeCode()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction GenerateEmployeeCode_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fnGenerateEmployeeCode));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction GenerateRepeatingEmployeeCode_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction GenerateRepeatingEmployeeCode_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NameFourChar_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction GenerateRepeatingEmployeeCode_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NameThreeChar_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NameThreeCharRepeating_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NameThreeCharRepeating_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NameThreeCharRepeating_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NameThreeCharRepeatingTwice_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NameThreeCharRepeatingTwice_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NameThreeCharRepeatingTwice_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction GetXXXXXVALForThreeLetterName_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction GetXXXXXVALForThreeLetterName_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction GetXXXXXVALForThreeLetterName_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            this.GenerateEmployeeCodeData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.GenerateRepeatingEmployeeCodeData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.NameFourCharData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.NameThreeCharData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.NameThreeCharRepeatingData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.NameThreeCharRepeatingTwiceData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.GetXXXXXVALForThreeLetterNameData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            GenerateEmployeeCode_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            GenerateRepeatingEmployeeCode_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            GenerateRepeatingEmployeeCode_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            NameFourChar_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            GenerateRepeatingEmployeeCode_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            NameThreeChar_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            NameThreeCharRepeating_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            NameThreeCharRepeating_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            NameThreeCharRepeating_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            NameThreeCharRepeatingTwice_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            NameThreeCharRepeatingTwice_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            NameThreeCharRepeatingTwice_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            GetXXXXXVALForThreeLetterName_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            GetXXXXXVALForThreeLetterName_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            GetXXXXXVALForThreeLetterName_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testCleanupAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // GenerateEmployeeCode_TestAction
            // 
            GenerateEmployeeCode_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(GenerateEmployeeCode_TestAction, "GenerateEmployeeCode_TestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "SHANT";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // GenerateRepeatingEmployeeCode_TestAction
            // 
            GenerateRepeatingEmployeeCode_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(GenerateRepeatingEmployeeCode_TestAction, "GenerateRepeatingEmployeeCode_TestAction");
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "HRIST";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // GenerateRepeatingEmployeeCode_PretestAction
            // 
            resources.ApplyResources(GenerateRepeatingEmployeeCode_PretestAction, "GenerateRepeatingEmployeeCode_PretestAction");
            // 
            // NameFourChar_TestAction
            // 
            NameFourChar_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(NameFourChar_TestAction, "NameFourChar_TestAction");
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 1;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "SUKIS";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
            // 
            // GenerateRepeatingEmployeeCode_PosttestAction
            // 
            resources.ApplyResources(GenerateRepeatingEmployeeCode_PosttestAction, "GenerateRepeatingEmployeeCode_PosttestAction");
            // 
            // NameThreeChar_TestAction
            // 
            NameThreeChar_TestAction.Conditions.Add(scalarValueCondition4);
            resources.ApplyResources(NameThreeChar_TestAction, "NameThreeChar_TestAction");
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 1;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = "SUKSU";
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = false;
            scalarValueCondition4.ResultSet = 1;
            scalarValueCondition4.RowNumber = 1;
            // 
            // NameThreeCharRepeating_TestAction
            // 
            NameThreeCharRepeating_TestAction.Conditions.Add(scalarValueCondition5);
            resources.ApplyResources(NameThreeCharRepeating_TestAction, "NameThreeCharRepeating_TestAction");
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 1;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = "UKSUK";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // NameThreeCharRepeating_PretestAction
            // 
            resources.ApplyResources(NameThreeCharRepeating_PretestAction, "NameThreeCharRepeating_PretestAction");
            // 
            // NameThreeCharRepeating_PosttestAction
            // 
            resources.ApplyResources(NameThreeCharRepeating_PosttestAction, "NameThreeCharRepeating_PosttestAction");
            // 
            // NameThreeCharRepeatingTwice_TestAction
            // 
            NameThreeCharRepeatingTwice_TestAction.Conditions.Add(scalarValueCondition6);
            resources.ApplyResources(NameThreeCharRepeatingTwice_TestAction, "NameThreeCharRepeatingTwice_TestAction");
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 1;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = "KSUKS";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 1;
            scalarValueCondition6.RowNumber = 1;
            // 
            // NameThreeCharRepeatingTwice_PretestAction
            // 
            resources.ApplyResources(NameThreeCharRepeatingTwice_PretestAction, "NameThreeCharRepeatingTwice_PretestAction");
            // 
            // NameThreeCharRepeatingTwice_PosttestAction
            // 
            resources.ApplyResources(NameThreeCharRepeatingTwice_PosttestAction, "NameThreeCharRepeatingTwice_PosttestAction");
            // 
            // GetXXXXXVALForThreeLetterName_TestAction
            // 
            GetXXXXXVALForThreeLetterName_TestAction.Conditions.Add(scalarValueCondition7);
            resources.ApplyResources(GetXXXXXVALForThreeLetterName_TestAction, "GetXXXXXVALForThreeLetterName_TestAction");
            // 
            // scalarValueCondition7
            // 
            scalarValueCondition7.ColumnNumber = 1;
            scalarValueCondition7.Enabled = true;
            scalarValueCondition7.ExpectedValue = "XXXXX";
            scalarValueCondition7.Name = "scalarValueCondition7";
            scalarValueCondition7.NullExpected = false;
            scalarValueCondition7.ResultSet = 1;
            scalarValueCondition7.RowNumber = 1;
            // 
            // GetXXXXXVALForThreeLetterName_PretestAction
            // 
            resources.ApplyResources(GetXXXXXVALForThreeLetterName_PretestAction, "GetXXXXXVALForThreeLetterName_PretestAction");
            // 
            // GetXXXXXVALForThreeLetterName_PosttestAction
            // 
            resources.ApplyResources(GetXXXXXVALForThreeLetterName_PosttestAction, "GetXXXXXVALForThreeLetterName_PosttestAction");
            // 
            // testCleanupAction
            // 
            resources.ApplyResources(testCleanupAction, "testCleanupAction");
            // 
            // GenerateEmployeeCodeData
            // 
            this.GenerateEmployeeCodeData.PosttestAction = null;
            this.GenerateEmployeeCodeData.PretestAction = null;
            this.GenerateEmployeeCodeData.TestAction = GenerateEmployeeCode_TestAction;
            // 
            // GenerateRepeatingEmployeeCodeData
            // 
            this.GenerateRepeatingEmployeeCodeData.PosttestAction = GenerateRepeatingEmployeeCode_PosttestAction;
            this.GenerateRepeatingEmployeeCodeData.PretestAction = GenerateRepeatingEmployeeCode_PretestAction;
            this.GenerateRepeatingEmployeeCodeData.TestAction = GenerateRepeatingEmployeeCode_TestAction;
            // 
            // NameFourCharData
            // 
            this.NameFourCharData.PosttestAction = null;
            this.NameFourCharData.PretestAction = null;
            this.NameFourCharData.TestAction = NameFourChar_TestAction;
            // 
            // NameThreeCharData
            // 
            this.NameThreeCharData.PosttestAction = null;
            this.NameThreeCharData.PretestAction = null;
            this.NameThreeCharData.TestAction = NameThreeChar_TestAction;
            // 
            // NameThreeCharRepeatingData
            // 
            this.NameThreeCharRepeatingData.PosttestAction = NameThreeCharRepeating_PosttestAction;
            this.NameThreeCharRepeatingData.PretestAction = NameThreeCharRepeating_PretestAction;
            this.NameThreeCharRepeatingData.TestAction = NameThreeCharRepeating_TestAction;
            // 
            // NameThreeCharRepeatingTwiceData
            // 
            this.NameThreeCharRepeatingTwiceData.PosttestAction = NameThreeCharRepeatingTwice_PosttestAction;
            this.NameThreeCharRepeatingTwiceData.PretestAction = NameThreeCharRepeatingTwice_PretestAction;
            this.NameThreeCharRepeatingTwiceData.TestAction = NameThreeCharRepeatingTwice_TestAction;
            // 
            // GetXXXXXVALForThreeLetterNameData
            // 
            this.GetXXXXXVALForThreeLetterNameData.PosttestAction = GetXXXXXVALForThreeLetterName_PosttestAction;
            this.GetXXXXXVALForThreeLetterNameData.PretestAction = GetXXXXXVALForThreeLetterName_PretestAction;
            this.GetXXXXXVALForThreeLetterNameData.TestAction = GetXXXXXVALForThreeLetterName_TestAction;
            // 
            // fnGenerateEmployeeCode
            // 
            this.TestCleanupAction = testCleanupAction;
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
        public void GenerateEmployeeCode()
        {
            //bool flg = false;
            //TransactionScope ts = new TransactionScope(TransactionScopeOption.Required);
            //ExecutionContext.Connection.EnlistTransaction(Transaction.Current);
            //PrivilegedContext.Connection.EnlistTransaction(Transaction.Current);

            SqlDatabaseTestActions testActions = this.GenerateEmployeeCodeData;
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
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Trace.WriteLine(ex.Message);
            //    ts.Dispose();
            //    flg = true;
            //}
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
                //if (flg)
                //{
                //    ts.Complete();
                //}
            }
        }
        [TestMethod()]
        public void GenerateRepeatingEmployeeCode()
        {
            SqlDatabaseTestActions testActions = this.GenerateRepeatingEmployeeCodeData;
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
        public void NameFourChar()
        {
            SqlDatabaseTestActions testActions = this.NameFourCharData;
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
        public void NameThreeChar()
        {
            SqlDatabaseTestActions testActions = this.NameThreeCharData;
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
        public void NameThreeCharRepeating()
        {
            SqlDatabaseTestActions testActions = this.NameThreeCharRepeatingData;
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
        public void NameThreeCharRepeatingTwice()
        {
            SqlDatabaseTestActions testActions = this.NameThreeCharRepeatingTwiceData;
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
        public void GetXXXXXVALForThreeLetterName()
        {
            SqlDatabaseTestActions testActions = this.GetXXXXXVALForThreeLetterNameData;
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






        private SqlDatabaseTestActions GenerateEmployeeCodeData;
        private SqlDatabaseTestActions GenerateRepeatingEmployeeCodeData;
        private SqlDatabaseTestActions NameFourCharData;
        private SqlDatabaseTestActions NameThreeCharData;
        private SqlDatabaseTestActions NameThreeCharRepeatingData;
        private SqlDatabaseTestActions NameThreeCharRepeatingTwiceData;
        private SqlDatabaseTestActions GetXXXXXVALForThreeLetterNameData;
    }
}
