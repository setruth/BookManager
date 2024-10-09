namespace BookManager.Model
{
    public class FrameLoadingLaunchBcast
    {
        public FrameLoadingLaunchBcast(string msg)
        {
            Msg = msg;
        }

        public readonly string Msg;
    }
    public class FrameLoadingStopBcast{}
}