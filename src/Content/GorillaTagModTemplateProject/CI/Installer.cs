using Bepinject;

namespace GorillaTagModTemplateProject
{
    public static class CI
    {
        public static void Init() { Zenjector.Install<MyModView>().OnProject(); }
    }
}
