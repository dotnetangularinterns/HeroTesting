using HeroesApi;
using HeroesApi.services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace HeroesApiTest
{
    [TestClass]
    public class HeroesTest
    {
        [TestMethod]
        public void add_new_hero()
        {
            HeroesService heroes = new HeroesService();

            Hero chris = new Hero();
            chris.Name = "Chris";
            chris.Pic = "https://making-the-web.com/sites/default/files/clipart/142014/stick-figure-142014-5551841.jpg";
            chris.Power = 2;

            heroes.Add(chris);

            Hero ashazi = new Hero();
            ashazi.Name = "Ashazi";
            ashazi.Pic = "http://clipart-library.com/images/pio5eXK6T.png";
            ashazi.Power = 3;

            heroes.Add(ashazi);

            Hero pasha = new Hero();
            pasha.Name = "Pasha";
            pasha.Pic = "https://image.shutterstock.com/image-vector/stick-figure-business-ideas-260nw-220840597.jpg";
            pasha.Power = 4;

            heroes.Add(pasha);

            Hero marcus = new Hero();
            marcus.Name = "Marcus";
            marcus.Pic = "https://image.shutterstock.com/image-vector/stick-figure-celebration-cheer-260nw-331595411.jpg";
            marcus.Power = 2;

            heroes.Add(marcus);

            Hero dale = new Hero();
            dale.Name = "Dale";
            dale.Pic = "https://images2.minutemediacdn.com/image/upload/c_crop,h_1180,w_2100,x_0,y_94/f_auto,q_auto,w_1100/v1555001162/shape/mentalfloss/504106-wikipedia.jpg";
            dale.Power = 5;

            heroes.Add(dale);

            Assert.AreEqual(5, heroes.GetHeroes().Count());

        }
        //add Heroes[Test]  


        [TestMethod]
        public void get_hero()
        {
            HeroesService heroes = new HeroesService();

            var hero = new Hero();
            string name = "Ma";

            IEnumerable<Hero> filtered = heroes.SearchHeroes(name);

            Assert.AreEqual(1, filtered.Count());
            //get Heroes[Test]
        }

        [TestMethod]
        public void update_hero()
        {
            HeroesService heroes = new HeroesService();

            Hero hero = new Hero()
            {
                Id = 4,
                Name = "Dale",
                Pic = "https://images2.minutemediacdn.com/image/upload/c_crop,h_1180,w_2100,x_0,y_94/f_auto,q_auto,w_1100/v1555001162/shape/mentalfloss/504106-wikipedia.jpg",
                Power = 3

            };

            heroes.Update(hero);

            Assert.AreEqual(3, heroes.GetById(4).Power);
            

            //update Heroes[Test]
        }

        [TestMethod]
        public void remove_hero()
        {
            HeroesService heroes = new HeroesService();
            List<Hero> heroList = heroes.GetHeroes().ToList();
            int n = heroList.Count();

            foreach (Hero h in heroList)
            {
                heroes.Remove(h.Id);
            }

            Assert.AreEqual(0, heroes.GetHeroes().Count());

        }
        //[TestMethod]
        //public void remove_hero()
        //{
        //    var hero = new Hero();

        //    hero.removeHero(4);

        //    Assert.AreEqual(3, hero.GetHeroes().Count());
        //    //subtract Heroes[Test]
        //}
    }
}