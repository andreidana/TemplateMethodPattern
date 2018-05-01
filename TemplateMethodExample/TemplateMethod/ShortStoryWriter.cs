using System;

namespace TemplateMethodExample.TemplateMethod
{
    public class ShortStoryWriter: Writer
    {
        public override void DesignCover()
        {
            Console.WriteLine("Design short story cover");
        }

        public override void WritePreface()
        {
            Console.WriteLine("Write short story preface");
        }

        public override void WriteChapters()
        {
            Console.WriteLine("Write short story chapters");
        }

        public override void WriteEnding()
        {
            Console.WriteLine("Write short story ending");
        }
    }
}