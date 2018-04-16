namespace Solid_Examples
{
    public class Copy
    {
        //public void CopyIt()
        //{
        //    var text = new ReadKeyboard().ReadIt();
        //    new WriteScreen().WriteIt(text);
        //}
        public void CopyIt(IRead from, IWrite to)
        {
            var text = from.ReadIt();
            to.WriteIt(text);
        }
    }
}
