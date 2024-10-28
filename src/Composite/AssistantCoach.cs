namespace Composite
{
    public class AssistantCoach : User, IOrganizationComposite
    {
        public AssistantCoach(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
