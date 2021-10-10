public interface IRoverOperaiton
{
    IRoverOperaiton DefineCordinate(string cordinat);
    IRoverOperaiton SetCommand(string command);
    string Move(string coordinate, string command, string plateau);
}