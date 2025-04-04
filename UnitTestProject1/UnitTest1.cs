using Microsoft.VisualStudio.TestTools.UnitTesting; 
using ExamCalculator;
using System.Windows; 

namespace ExamCalculatorTests
{
    [TestClass] 
    public class ExamCalculatorTests
    {
        [TestMethod] 
        public void GetGrade_Excellent()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(100);
            Assert.AreEqual("5 (отлично)", grade); 
        }

        [TestMethod]
        public void GetGrade_Good()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(60);
            Assert.AreEqual("4 (хорошо)", grade);
        }

        [TestMethod]
        public void GetGrade_Satisfactory()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(30);
            Assert.AreEqual("3 (удовлетворительно)", grade);
        }

        [TestMethod]
        public void GetGrade_Unsatisfactory()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(10);
            Assert.AreEqual("2 (неудовлетворительно)", grade);
        }

        [TestMethod]
        public void IsValidScore_ValidScore()
        {
            MainWindow form = new MainWindow();
            Assert.IsTrue(form.IsValidScore(5, 10));
        }

        [TestMethod]
        public void IsValidScore_InvalidScore_Negative()
        {
            MainWindow form = new MainWindow();
            Assert.IsFalse(form.IsValidScore(-1, 10));
        }

        [TestMethod]
        public void IsValidScore_InvalidScore_TooHigh()
        {
            MainWindow form = new MainWindow();
            Assert.IsFalse(form.IsValidScore(11, 10));
        }

       
    }
}