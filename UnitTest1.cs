using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using intModifier;
using stringModifier;
namespace HeroTesting
{
    [TestClass]
    public class HeroTesting
    {
        public void add_new_hero_list()
        {
            var hero = new Hero();

            Assert.IsNotNull(hero.GetHeroes());
        }

        [TestMethod]
        public void add_hero_when_hero_submitted()
        {
            var hero = new Hero();

            Hero hero = new Hero()
            {
                Hero.name = "Dale",
                Pic = "https://images2.minutemediacdn.com/image/upload/c_crop,h_1180,w_2100,x_0,y_94/f_auto,q_auto,w_1100/v1555001162/shape/mentalfloss/504106-wikipedia.jpg",
                Power = 5.0
            };

            int id = Hero.GenerateId();
            hero.Id = id;
            heroes.Add(hero);

            Assert.AreEqual(id, hero.GetHeroes().Last().Id);
        }
        //add Heroes[Test]  


        [TestMethod]
        public void get_hero_when_hero_added()
        {
            var hero = new Hero();
            string name = "Ma";

            IEnumerable<Hero> filtered = hero.GetHeroes(name);

            Assert.AreEqual(1, filtered.Count());
            //get Heroes[Test]
        }

        [TestMethod]
        public void update_hero_when_hero_added()
        {
            var hero = new Hero();
            Hero hero = new Hero()
            {
                Id = 4,
                Name = "Dale",
                Pic = "https://images2.minutemediacdn.com/image/upload/c_crop,h_1180,w_2100,x_0,y_94/f_auto,q_auto,w_1100/v1555001162/shape/mentalfloss/504106-wikipedia.jpg",
                Power = 3

            };

            hero.Update(hero);

            Assert.AreEqual(10, hero.GetHeroes().Power);

            //update Heroes[Test]
        }

        [TestMethod]
        public void remove_hero()
        {
            var hero = new Hero();

            hero.removeHero(4);

            Assert.AreEqual(3, hero.GetHeroes().Count());
            //subtract Heroes[Test]
        }
    }
}
