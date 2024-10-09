namespace BookManager.Model
{
    public delegate void LoginSuccessEventHandler();

    public delegate void ToRegisterEventHandler();

    public delegate void RegisterSuccessEventHandler(string registerAct);

    public delegate void ToLoginEventHandler();
    
}