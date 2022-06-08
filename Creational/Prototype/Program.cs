// set up prototype object
using Prototype;

CourseImage prototype = new CourseImage();
prototype.Initialize();

// create image of laptop with blueprint
CourseImageMaker maker = new CourseImageMaker();
CourseImage blueprint = maker.CreateImage(prototype, "course_image_1.png");
blueprint.Save("blueprint.png");

// create image of laptop with threads
CourseImage threads = maker.CreateImage(prototype, "course_image_2.png");
threads.Save("threads.png");

// create image of laptop with memory cards
CourseImage memory = maker.CreateImage(prototype, "course_image_3.png");
memory.Save("memory.png");