
namespace JOGO_RPG.src
{
     public class Hero{
         
            public String Name { get; set; }
            public int Level { get; set; }
            public String HeroType { get; set; 
            
            }

        public Hero(){
            //Posso fazer um construtor vazio, para que seja possível instanciar a classe sem parametros.
            //graças ao conceito de polimorfismo, é possível existirem 2 métodos de mesmo nome, porém com funções diferentes.
        }

        public Hero(String Name, int Level, String HeroType){ // Metodo construtor

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString() //Override é usado para sobrescrever novos comportamentos em relação a classe mãe.
        { // É usado override no toString, pois já existe uma classe com o mesmo nome no sistema.
            return " Name= "+this.Name + " Level= " + this.Level + " Type= " + this.HeroType;
        }

        public virtual string Attack(){ //virtual da a permissão para métodos filhos sobrescreverem o método referente.
            return this.Name + " Atacou você com você com espada";
        }

    } 

}