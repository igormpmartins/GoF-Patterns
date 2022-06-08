using Decorator;

var pizza = new WithExtraHam(
    new Margarita()
    );

var price = pizza.GetPrice();
Console.WriteLine($"Margarita + ham: {price}");

var pizza2 = new WithExtraCheese(
                new WithExtraHam(
                    new QuatroStagioni()
                    )
                );

price = pizza2.GetPrice();
Console.WriteLine($"4 stagioni + ham + cheese: {price}");



