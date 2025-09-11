function operadoresAritmeticos01() {
    let numero1 = parseInt(prompt("Digite o primeiro número:"));
    let numero2 = parseInt(prompt("Digite o segundo número:"));
    let soma = numero1 + numero2;
    alert("A soma é: " + soma);
}

function operadoresAritmeticos02() {
    let numero1 = parseInt(prompt("Digite o primeiro número"));
    let numero2 = parseInt(prompt("Digite o segundo número"));
    let subtrair = numero1 - numero2;
    alert("A difernça é de: " + subtrair);
}

function operadoresAritmeticos03() {
    let numero1 = parseInt(prompt("Digite o primeiro número"));
    let numero2 = parseInt(prompt("Digite o segundo número"));
    let multiplicar = numero1 * numero2;
    alert("A produto é de: " + multiplicar);
}

function operadoresAritmeticos04() {
    let numero1 = parseInt(prompt("Digite o primeiro número"));
    let numero2 = parseInt(prompt("Digite o segundo número"));
    let divisao = numero1 / numero2;
    alert("A divisão é de: " + divisao);
}

function operadoresAtribuicao01() {
    let numb = 3456;
    alert("o valor da variável é " + numb);
}

function operadoresAtribuicao02() {
    let numb = 3453;
    alert("o valor da variável é de " + numb);
    let numb2 = parseInt(prompt("Digite o valor para atribuir a variável"));
    let soma = numb + numb2;
    alert("O valor da variável é " + soma);
}

function operadoresAtribuicao03() {
    let numb = 3453;
    alert("o valor da variável é de " + numb);
    let numb2 = parseInt(prompt("Digite o valor para subtrair da variável"));
    let subtrair = numb * numb2;
    alert("O valor da variável é " + subtrair);
}

function operadoresAtribuicao04() {
    let numb = 3400;
    alert("o valor da variável é de " + numb);
    let numb2 = parseInt(prompt("Digite o valor para divisão da variável"));
    let dividir = numb / numb2;
    alert("O valor da variável é " + dividir);
}