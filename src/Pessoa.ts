export class Pessoa 
{
    private Nome: string = ""
    private Idade : number = 0
    
    /**
     *
     */
    constructor(nome: string, idade: number) {
        this.Nome = nome;
        this.Idade = idade;
    }
}