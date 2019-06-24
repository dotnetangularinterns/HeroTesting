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
            var hero = new Hero();
            hero.name = "Dale";

            heros.Add(new Hero { Id = 0, Name = "Chris", Pic = "https://making-the-web.com/sites/default/files/clipart/142014/stick-figure-142014-5551841.jpg", Power = 1.5 });
            heros.Add(new Hero { Id = 1, Name = "Marcus", Pic = "https://image.shutterstock.com/image-vector/stick-figure-celebration-cheer-260nw-331595411.jpg", Power = 2 });
            heros.Add(new Hero { Id = 2, Name = "Ashazi", Pic = "http://clipart-library.com/images/pio5eXK6T.png", Power = 3 });
            heros.Add(new Hero { Id = 3, Name = "Pasha", Pic = "https://image.shutterstock.com/image-vector/stick-figure-business-ideas-260nw-220840597.jpg", Power = 4 });
            heros.Add(new Hero { Id = 4, Name = "Dale", Pic = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.pixabay.com%2Fphoto%2F2014%2F11%2F11%2F01%2F24%2Fstrong-526265_960_720.jpg&imgrefurl=https%3A%2F%2Fpixabay.com%2Fillustrations%2Fstrong-stick-figure-adult-happy-526265%2F&docid=ExWGomSs9u8G9M&tbnid=8OGGvW0IblR0AM%3A&vet=10ahUKEwjlz_GE9YLjAhWxc98KHYmvDtoQMwhaKAEwAQ..i&w=478&h=720&safe=active&bih=969&biw=1920&q=strong%20stick%20figure&ved=0ahUKEwjlz_GE9YLjAhWxc98KHYmvDtoQMwhaKAEwAQ&iact=mrc&uact=8 ", Power = 2.5 });

            heros.addHero(hero);
        }
            //add Heroes[Test]  
    }

        [TestMethod]
        public void should_get_hero()
        {
            var hero = Hero(int id);
            heros.getHero = 2;

            result.Make.ShouldEqual("Chris");
            //get Heroes[Test]
        }

        [TestMethod]
        public void should_update_hero()
        {
            


            result.Make.ShouldEqual(5);

            //update Heroes[Test]
        }

        [TestMethod]
        public void should_remove_hero()
        { 
             var hero = Hero(int id);
             heros.removeHero = 4;

                heros.Add(new Hero { Id = 0, Name = "Chris", Pic = "https://making-the-web.com/sites/default/files/clipart/142014/stick-figure-142014-5551841.jpg", Power = 1.5 });
                heros.Add(new Hero { Id = 1, Name = "Marcus", Pic = "https://image.shutterstock.com/image-vector/stick-figure-celebration-cheer-260nw-331595411.jpg", Power = 2 });
                heros.Add(new Hero { Id = 2, Name = "Ashazi", Pic = "http://clipart-library.com/images/pio5eXK6T.png", Power = 3 });
                heros.Add(new Hero { Id = 3, Name = "Pasha", Pic = "https://image.shutterstock.com/image-vector/stick-figure-business-ideas-260nw-220840597.jpg", Power = 4 });
                heros.Add(new Hero { Id = 4, Name = "Dale", Pic = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.pixabay.com%2Fphoto%2F2014%2F11%2F11%2F01%2F24%2Fstrong-526265_960_720.jpg&imgrefurl=https%3A%2F%2Fpixabay.com%2Fillustrations%2Fstrong-stick-figure-adult-happy-526265%2F&docid=ExWGomSs9u8G9M&tbnid=8OGGvW0IblR0AM%3A&vet=10ahUKEwjlz_GE9YLjAhWxc98KHYmvDtoQMwhaKAEwAQ..i&w=478&h=720&safe=active&bih=969&biw=1920&q=strong%20stick%20figure&ved=0ahUKEwjlz_GE9YLjAhWxc98KHYmvDtoQMwhaKAEwAQ&iact=mrc&uact=8 ", Power = 2.5 });


            HeroList.Remove(Id = 4);
            //subtract Heroes[Test]
        }
}