namespace ams_heranca_treeclass_pessoa{
class Fisica : Persons{
        public Fisica(string id, string name) : base(id, name){
        }

        public virtual void Tiozinho(){
            Console.WriteLine($"A {Name}, é uma pessoa como as outras.");
            Console.WriteLine($"O ID da da pessoa comum é: {CPF}");
        }
    }
}