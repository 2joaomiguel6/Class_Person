namespace ams_heranca_treeclass_pessoa{
class Juri : Persons{
        public Juri(string id, string name) : base(id, name){
        }

        public virtual void Juridico(){
            Console.WriteLine($"O {Name}, é uma que cuida dos direitos das pessoas.");
            Console.WriteLine($"O ID da águia é: {CPF}");
        }
    }
}