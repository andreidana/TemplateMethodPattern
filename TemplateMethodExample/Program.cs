using TemplateMethodExample.TemplateMethod;

namespace TemplateMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var novel = new NovelWriter();
            novel.TemplateMethod();

            var shortStory = new ShortStoryWriter();
            shortStory.TemplateMethod();
        }
    }
}
