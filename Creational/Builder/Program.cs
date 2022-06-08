using Builder;

MenuDirector director = new MenuDirector();

MenuBuilder builder1 = new BurgerMenuBuilder();
director.Construct(builder1);
Menu menu1 = builder1.GetResult();
Console.WriteLine($"Burger menu: {menu1}");

MenuBuilder builder2 = new KidsMenuBuilder();
director.Construct(builder2);
Menu menu2 = builder2.GetResult();
Console.WriteLine($"Kids menu: {menu2}");


