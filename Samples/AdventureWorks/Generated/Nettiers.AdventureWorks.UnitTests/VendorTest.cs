﻿


#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;

#endregion

namespace Nettiers.AdventureWorks.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="Vendor"/> objects (entity, collection and repository).
    /// </summary>
	/// <remarks>
	/// This file is generated once and will never be overwritten.
	/// </remarks>
    [TestFixture]
    public partial class VendorTest
    {    	
		/// <summary>
		/// Creates a new <see cref="VendorTest"/> instance.
		/// </summary>	
		public VendorTest()
		{				
		}
      
		
		/// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
		[TestFixtureSetUp]
		public void Init()
        {
			Init_Generated();
			// Add your initialization here
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		[TestFixtureTearDown]
        public void Dispose()
        {   
        	CleanUp_Generated();
			// Add you clean up here
        }
    
    
		/// <summary>
		/// Inserts a mock Vendor entity into the database.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_01_Insert()
		{
			// Establish additional pre-conditions here
			Step_01_Insert_Generated();			
			// Add additional verification here
		}
		
		
		/// <summary>
		/// Selects a sample of  Vendor objects of the database.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_02_SelectAll()
		{
			// Establish additional pre-conditions here
			Step_02_SelectAll_Generated();
			// Add additional verification here
		}
		
		
		
		
		/// <summary>
		/// Deep load all Vendor children.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_03_DeepLoad()
		{
			// Establish additional pre-conditions here
			Step_03_DeepLoad_Generated();
			// Add additional verification here
		}
		
		/// <summary>
		/// Updates a mock Vendor entity into the database.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_04_Update()
		{
			// Establish additional pre-conditions here
			Step_04_Update_Generated();
			// Add additional verification here
		}
		
		
		/// <summary>
		/// Delete the mock Vendor entity into the database.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_05_Delete()
		{
			// Establish additional pre-conditions here
			Step_05_Delete_Generated();
			// Add additional verification here
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock Vendor entity into a temporary file.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_06_SerializeEntity()
		{
			// Establish additional pre-conditions here
			Step_06_SerializeEntity_Generated();
			// Add additional verification here
		}
		
		/// <summary>
		/// Deserialize the mock Vendor entity from a temporary file.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_07_DeserializeEntity()
		{
			// Establish additional pre-conditions here
			Step_07_DeserializeEntity_Generated();
			// Add additional verification here
		}
		
		/// <summary>
		/// Serialize a Vendor collection into a temporary file.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_08_SerializeCollection()
		{
			// Establish additional pre-conditions here
			Step_08_SerializeCollection_Generated();
			// Add additional verification here
		}
		
		
		/// <summary>
		/// Deserialize a Vendor collection from a temporary file.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_09_DeserializeCollection()
		{
			// Establish additional pre-conditions here
			Step_09_DeserializeCollection_Generated();
			// Add additional verification here
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_10_FK()
		{
			// Establish additional pre-conditions here
			Step_10_FK_Generated();
			// Add additional verification here
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_11_IX()
		{
			// Establish additional pre-conditions here
			Step_11_IX_Generated();
			// Add additional verification here
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		[NUnit.Framework.Test]
		public void Step_20_TestEntityHelper()
		{
			Step_20_TestEntityHelper_Generated();
		}

        /// <summary>
        /// Test Find using the Query class
        /// </summary>
        [NUnit.Framework.Test]
        public void Step_30_TestFindByQuery()
        {
            Step_30_TestFindByQuery_Generated();
        }

        ///<summary>
        ///  Returns a Typed Vendor Entity with mock values.
        ///</summary>
        static public Vendor CreateMockInstance(TransactionManager tm)
        {
            // get the default mock instance
            Vendor mock = VendorTest.CreateMockInstance_Generated(tm);
			
            // make any alterations necessary 
            // (i.e. for DB check constraints, special test cases, etc.)
			SetSpecialTestData(mock);
			
            // return the modified object
            return mock;
        }

        ///<summary>
        ///  Update the Typed Vendor Entity with modified mock values.
        ///</summary>
        static public void UpdateMockInstance(TransactionManager tm, Vendor mock)
        {
            VendorTest.UpdateMockInstance_Generated(tm, mock);
            
			// make any alterations necessary 
            // (i.e. for DB check constraints, special test cases, etc.)
			SetSpecialTestData(mock);
        }
		
		/// <summary>
        /// Make any alterations necessary (i.e. for DB check constraints, special test cases, etc.)
        /// </summary>
        /// <param name="mock">Object to be modified</param>
        static private void SetSpecialTestData(Vendor mock)
        {
            //Code your changes to the data object here.
            mock.CreditRating = TestUtility.Instance.RandomByte(1, 5);
        }
    }
}
