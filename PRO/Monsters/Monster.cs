namespace Monsters
{
public class Monster
{
    string _monsterName = "###";

    public string monsterName
    {
        get
        {
            return _monsterName;
        }
        set
        {
            _monsterName = value;
        }
    }
    
    int _monsterHealth = 100;

    public int monsterHealth
    {
        get
        {
            return _monsterHealth;
        }
        set
        {
            _monsterHealth = value;            
        }
    }

    public Monster(string nameInput, int healthInput, Program program)
    {
        monsterName = nameInput;
        monsterHealth = healthInput;
        program.monsterAmount += 1;
    }

    public void die(Program program)
    {
        if(monsterHealth <= 0)
        {
            program.monsterAmount -= 1;
        }
    }
}
}