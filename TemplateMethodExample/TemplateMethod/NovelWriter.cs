using System;

namespace TemplateMethodExample.TemplateMethod
{
    public class NovelWriter: Writer
    {
        public override void DesignCover()
        {
            Console.WriteLine("Design novel cover");
        }

        public override void WritePreface()
        {
            Console.WriteLine("Write novel preface");
        }

        public override void WriteChapters()
        {
            Console.WriteLine("Write novel chapters");
        }

        public override void WriteEnding()
        {
            Console.WriteLine("Write novel ending");
        }
    }
}