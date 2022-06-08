using Observer;

var timer = new ConsoleTimer();
var clock = new ConsoleClock();

timer.Notify += clock.Update;
timer.Start();
