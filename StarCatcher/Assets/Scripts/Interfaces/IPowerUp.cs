public interface IPowerUp 
{
	//Think of an interface as a list of requirements. Everything that uses the interface requires the variables/functions in the interface script.
	//Power is a property, and you can either get it or set it, though it requires the keyword. 
	int power { get; }
	//Start is required for this script
	void Start();
	//A trigger is required for the powerup
	void OnTriggerEnter();

}
