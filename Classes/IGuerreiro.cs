namespace Guerreiros
{
    interface IGuerreiro
    {
        /** Métodos **/
        void Atacar(GuerreiroAbstrato guerreiro);
        void equiparArma(ArmaAbstrato arma);
        void equiparArmadura(ArmaduraAbstrato armadura);

    }
}