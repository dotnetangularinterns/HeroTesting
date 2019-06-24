using Microsoft.VisualStudio.TestTools.UnitTesting;
int Modifier;
string Modifier;
namespace HeroTesting
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void should_add_hero()
        {
            var result = _HeroList.addHero(int);

            result.Make.ShouldEqual(5);

            //add Heroes[Test]  
        }

        [TestMethod]
        public void should_create_get_hero()
        {
            var result = _HeroList.getHero("S");

            result.Make.ShouldEqual("Chris");
            //get Heroes[Test]
        }

        [TestMethod]
        public void should_update_hero()
        {
            var result = _HeroList.updateHero(int);

            result.Make.ShouldEqual(5);

            //update Heroes[Test]
        }

        [TestMethod]
        public void should_remove_hero()
        {
            var result = _HeroList.removeHero(int);

            result.Make.ShouldEqual(4);

            //subtract Heroes[Test]
        }
    }
}