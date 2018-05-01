namespace TemplateMethodExample.TemplateMethod
{
    public abstract class Writer
    {
        public abstract void DesignCover();
        public abstract void WritePreface();
        public abstract void WriteChapters();
        public abstract void WriteEnding();

        public void TemplateMethod()
        {
            DesignCover();
            WritePreface();
            WriteChapters();
            WriteEnding();
        }
    }
}