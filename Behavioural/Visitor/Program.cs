using Visitor;

var catalog = new Catalog();
catalog.Add(new Book());
catalog.Add(new Book());
catalog.Add(new Book());
catalog.Add(new Book());
catalog.Add(new Book());

catalog.Add(new Movie());
catalog.Add(new Movie());
catalog.Add(new Movie());
catalog.Add(new Movie());

catalog.Add(new Toy());
catalog.Add(new Toy());
catalog.Add(new Toy());
catalog.Add(new Toy());

catalog.Add(new Clothing());
catalog.Add(new Clothing());
catalog.Add(new Clothing());
catalog.Add(new Clothing());
catalog.Add(new Clothing());
catalog.Add(new Clothing());

var partitioner = new ProductPartitioner();
catalog.Accept(partitioner);

Console.WriteLine("{0} books", partitioner.Books);
Console.WriteLine("{0} movies", partitioner.Movies);
Console.WriteLine("{0} toys", partitioner.Toys);
Console.WriteLine("{0} clothing", partitioner.Clothing);
