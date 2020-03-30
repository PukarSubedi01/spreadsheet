using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spreadsheet_assignment;
namespace Formulas.Test
{
    [TestClass]
    public class ExcelFormulaTesting
    {
       
        [TestMethod]
        public void SumTest()   //true testing
        {
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1 };
                double Result = ef.GetSum(values);
                Assert.AreEqual(134, Result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        [TestMethod]
        public void SumTest1()   //false testing
        {
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1 };
                double Result = ef.GetSum(values);
                Assert.AreEqual(13, Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void MeanTest()
        {
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1 };
                double Result = ef.GetMean(values);
                Assert.AreEqual(33.5, Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void MeanTest1() //false test
        {
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1 };
                double Result = ef.GetMean(values);
                Assert.AreEqual(33, Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        [TestMethod]
        public void MedianTrueTest1()
        {//This test for finding median is done for list containing even count of values.
            ListManipulation LM = new ListManipulation();
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1 };
                List<double> sortedList = LM.GetAscendedList(values);
                //Sorted List is passed because number needs to be arranged in order.
                double Result = ef.GetMedian(sortedList);
                Assert.AreEqual(27.5, Result);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        [TestMethod]
        public void MedianFalseTest1()
        {//This test for finding median is done for list containing even count of values.
            ListManipulation LM = new ListManipulation();
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1 };
                List<double> sortedList = LM.GetAscendedList(values);
                double Result = ef.GetMedian(sortedList);
                Assert.AreEqual(27, Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        [TestMethod]
        public void MedianTrueTest2()
        {//This test for finding median is done for list containing odd count of values.
            ListManipulation LM = new ListManipulation();
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1, 56 };
                List<double> sortedList = LM.GetAscendedList(values);
                double Result = ef.GetMedian(sortedList);
                Assert.AreEqual(45, Result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [TestMethod]
        public void MedianFalseTest2()
        {//This test for finding median is done for list containing odd count of values.
            ListManipulation LM = new ListManipulation();
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1, 56 };
                List<double> sortedList = LM.GetAscendedList(values);
                double Result = ef.GetMedian(sortedList);
                Assert.AreEqual(56, Result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [TestMethod]
        public void ModeTest() //true test
        {
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1, 1, 10, 78, 1 };
                double Result = ef.GetMode(values);
                Assert.AreEqual(1, Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void ModeTest1() //false test
        {
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 45, 10, 78, 1, 1, 10, 78, 1 };
                double Result = ef.GetMode(values);
                Assert.AreEqual(10, Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void MultiplicationTest()              //true test
        {
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 5, 4 };
                Assert.AreEqual(20, ef.GetMultiply(values));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void MultiplicationTest1()              //false test
        {
            ExcelFormulas ef = new ExcelFormulas();
            try
            {
                List<double> values = new List<double> { 5, 4 };
                Assert.AreEqual(18, ef.GetMultiply(values));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
