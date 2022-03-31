namespace JOGO_RPG.src
{
    public class Wizard : Hero // tudo o que um heroi tem, o mago tem.
    {
        public Wizard(String Name, int Level, String HeroType){ // Metodo construtor

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            }

        public override string Attack(){
            return this.Name + " te lançou um feitiço";
        }

        public string Attack(int bonus){ //graças ao conceito de polimorfismo, o método Attack pode assumir várias formas, possibilitando chamá-lo de várias maneiras.

            if(bonus >  6){
                return this.Name + " te lançou um feitiço poderoso com bônus de " +bonus;
            } else{
                return this.Name + " te lançou um feitiço relevante com bônus de " +bonus;  
            }
        }
        
    }
}