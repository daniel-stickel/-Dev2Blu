const btnlistaNomes = document.getElementById('btnlistaNomes')
const btnAdivinhaNumero = document.getElementById('btnAdivinhaNumero');
const btnFatorial = document.getElementById('btnFatorial');

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
    let entrada = [];
    let soma = 0;

    for (let i = 0; i < 5; i++) {
        let entrada = parseInt(prompt(`Digite o ${i + 1}° número para soma`));
        soma = soma + entrada;
    }
    alert(`total da soma é ${soma}`);
}

function arrayMaiorMenor() {
    let valores = [];

    for (let i = 0; i < 10; i++) {
        let valorDigitado = parseInt(prompt(`Digite o ${i + 1}º número`));
        valores.push(valorDigitado);
    }

    if (valores.length > 0) {
        let maiorValor = valores[0];
        let menorValor = valores[0];

        for (let i = 1; i < valores.length; i++) {

            maiorValor = valores[i];
        }
        if (valores[i] < menorValor) {
            menorValor = valores[i];
        }
    }

    alert(`O menor valor é ${menorValor}\n` +
        `O maior valor é ${maiorValor}`);
}
function arrayOrdemIversa() {
    let nomes = [];
    let nomesInversos;

    for (let i = 0; i < 5; i++) {
        nomes[i] = prompt("Digite um nome:");
    }

    nomesInversos = nomes.slice().reverse();
    alert(nomesInversos)
    /*for(let i = nomes.length -1; i >=0; i--) {
        alert(nomes[i]);
    }*/

}

/* LIstas */  /* Forma certa de chamar um método uma function em javascrpt*/

/* Lista de nomes */

const listaNomes = function () {
    let nomes = [];
    alert("Digite quantos nomes desejar ou deixe em branco aperte ENTER")

    for (;;) {
        let entrada = prompt("Digite o nome para adicionar a lista");

        if(entrada === null || entrada.trim() === ""){
            break
        }
        nomes.push(entrada.trim());
    }

    let listaFinal =[];
    for( let nome of nomes) {
        listaFinal += `\n - ${nome}`; 
    }
    alert(listaFinal);
}

btnlistaNomes.addEventListener('click', listaNomes);


/* Adivinhando números da lista */

const advinhaNumeros = function () {
    const numeros = [12, 21, 36, 37, 55, 63, 73, 82, 89, 96];
    let entrada = parseInt(prompt("Digite um número de 1 a 100 para ver ser você é bom em adivinhar meus números secretos"));

    if (numeros.includes(entrada)) {
        alert(`Você é um cara de sorte, o número ${entrada} faz partes dos meus números`);
    } else {
        alert('Seu número não é compativel com o meu, você não tem sorte');
    }
}

btnAdivinhaNumero.addEventListener('click', advinhaNumeros);

/* Instrução For */

const fatorial = function () {
    let entrada = parseInt(prompt("Digite um número inteiro para obter o fatorial:"));
    let resultado = 1;

    for (let i = entrada; i > 1; i--) {
        resultado = resultado * i;
    }
    alert(`O fatorial de ${entrada} é ${resultado}.`);
}

btnFatorial.addEventListener('click', fatorial);