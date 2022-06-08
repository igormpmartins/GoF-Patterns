using AbstractFactory;

ContinentFactory factory1 = new AfricaFactory();
Ecosystem ecosystem1 = new Ecosystem(factory1);
ecosystem1.Run();

ContinentFactory factory2 = new AustralianFactory();
Ecosystem ecosystem2 = new Ecosystem(factory2);
ecosystem2.Run();


