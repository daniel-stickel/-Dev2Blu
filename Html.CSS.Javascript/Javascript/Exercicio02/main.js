/*Instrução If*/

function instrIf01() {
    let num = parseInt(prompt("Digite um número"));
    if (num % 2 == 0) {
        alert(`O número ${num} é par`);
    } else {
        alert(`O número ${num} é impar`);
    }
}

function instrIf02() {
    let nome = prompt("Digite seu nome: ");
    let idade = parseInt(prompt("Digite sua idade: "));
    if (idade < 18 || idade >= 60) {
        alert(`${nome} você não pode entra por norma de segurança`);
    } else {
        alert(`${nome} você  pode  entrar`);
    }
}

/*Instrução Switch*/

function InstrSwitch() {
    let dia = parseInt(prompt("Digite o numero para saber o dia da semana"));

    switch (dia) {
        case 1:
            alert("Domingo")
        break;
        case 2:
            alert("Segunda Feira")
        break;
        case 3:
            alert("Terça Feira")
        break;
        case 4:
            alert("Quarta Feira")
        break;
        case 5:
            alert("Quinta Feira")
        break;
        case 6:
            alert("Sexta Feira")
        break;
        case 7:
            alert("Sábado")
        break;
        default:
            alert("Dia Inválido")
    }
}

/*Array*/

function arraySoma() {
    let entrada = [5];
    let soma = 0;

    for(let i = 0; i < 5; i++) {
         let entrada = parseInt(prompt(`Digite o ${i+1}° número para soma`));
        soma = soma + entrada;
    }
    alert(`total da soma é ${soma}`);
}

function arrayMaiorMenor() {
    let valor = [10];
    let menorValor = null;
    let maiorValor = null;
}