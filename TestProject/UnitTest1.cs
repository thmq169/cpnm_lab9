using StudentServiceLib;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score_InRange10_ThrowException()
        {
           
            Student s = new Student();
            bool execption = false;
            try
            {

                s.Score = 8;

            }
            catch(SystemException e)
            {
               execption = true;
            }
            

            Assert.IsFalse(execption);
        }

        [TestMethod]
        public void Score8To10_LetterA()
        {

            Student s = new Student();

            s.Score = 8;

            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7To8_LetterB()
        {

            Student s = new Student();

            s.Score = 7;

            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }

    }
}