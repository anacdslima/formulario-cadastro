// Guardamos o formulário inteiro numa "caixinha" para usar depois
const form = document.getElementById('formCadastro');

// ==========================================
// FUNÇÃO 1 — VALIDAR TELEFONE
// ==========================================
function validarTelefone() {
    // Pegamos o que a pessoa digitou no campo
    const campo = document.getElementById('telefone');
    const erro = document.getElementById('erro-telefone');
    
    // Tiramos tudo que NÃO é número
    const apenasNumeros = campo.value.replace(/\D/g, '');
    
    // Verificamos se tem 10 ou 11 dígitos
    if (apenasNumeros.length !== 10 && apenasNumeros.length !== 11) {
        erro.textContent = '❌ Insira um número com DDD (10 ou 11 dígitos).';
        return false; // Deu errado!
    }
    
    // Se chegou aqui, está certo — limpa mensagem de erro
    erro.textContent = '';
    return true; // Deu certo!
}

// ==========================================
// FUNÇÃO 2 — VALIDAR E-MAIL
// ==========================================
function validarEmail() {
    const campo = document.getElementById('email');
    const erro = document.getElementById('erro-email');
    
    // Verifica se tem @ e um ponto depois dele
    const temArroba = campo.value.includes('@');
    const temPontoDepois = campo.value.indexOf('.') > campo.value.indexOf('@');
    
    if (!temArroba || !temPontoDepois) {
        erro.textContent = '❌ Digite um e-mail válido (ex: nome@exemplo.com).';
        return false;
    }
    
    erro.textContent = '';
    return true;
}

// ==========================================
// FUNÇÃO 3 — VALIDAR CPF
// ==========================================
function validarCPF() {
    const campo = document.getElementById('cpf');
    const erro = document.getElementById('erro-cpf');
    const valor = campo.value.replace(/\D/g, ''); // Só os números

    // Tem que ter exatamente 11 dígitos
    if (valor.length !== 11) {
        erro.textContent = '❌ Digite um CPF com 11 números.';
        return false;
    }

    // Não pode ser todos os números iguais (ex: 000.000.000-00)
    if (/^(\d)\1{10}$/.test(valor)) {
        erro.textContent = '❌ Esse não é um CPF válido.';
        return false;
    }

    // Cálculo do primeiro dígito verificador
    let soma = 0;
    for (let i = 0; i < 9; i++) {
        soma += parseInt(valor[i]) * (10 - i);
    }
    let digito1 = (soma * 10) % 11;
    if (digito1 === 10 || digito1 === 11) digito1 = 0;
    
    // Cálculo do segundo dígito verificador
    soma = 0;
    for (let i = 0; i < 10; i++) {
        soma += parseInt(valor[i]) * (11 - i);
    }
    let digito2 = (soma * 10) % 11;
    if (digito2 === 10 || digito2 === 11) digito2 = 0;

    // Conferimos se os dígitos batem
    if (parseInt(valor[9]) !== digito1 || parseInt(valor[10]) !== digito2) {
        erro.textContent = '❌ Esse CPF não existe. Confira os números.';
        return false;
    }

    erro.textContent = '';
    return true;
}

// ==========================================
// FUNÇÃO 4 — VALIDAR DATA DE NASCIMENTO
// ==========================================
function validarDataNascimento() {
    const campo = document.getElementById('nascimento');
    const erro = document.getElementById('erro-nascimento');
    const partes = campo.value.split('/'); // Separa por barra

    // Precisa ter dia/mês/ano → 3 partes
    if (partes.length !== 3) {
        erro.textContent = '❌ Use o formato: DD/MM/AAAA';
        return false;
    }

    const dia = parseInt(partes[0]);
    const mes = parseInt(partes[1]) - 1; // Meses no computador começam do 0
    const ano = parseInt(partes[2]);
    const dataDigitada = new Date(ano, mes, dia);
    const hoje = new Date(); // Pega a data de hoje automaticamente

    // Verifica se a data realmente existe
    if (dataDigitada.getDate() !== dia || 
        dataDigitada.getMonth() !== mes || 
        dataDigitada.getFullYear() !== ano) {
        erro.textContent = '❌ Essa data não existe. Confira dia, mês e ano.';
        return false;
    }

    // Não pode ser uma data no futuro
    if (dataDigitada > hoje) {
        erro.textContent = '❌ A data não pode ser no futuro.';
        return false;
    }

    erro.textContent = '';
    return true;
}

// ==========================================
// QUANDO A PESSOA CLICA EM "REALIZAR INSCRIÇÃO"
// ==========================================
form.addEventListener('submit', function(quandoEnviar) {
    // Não deixa o formulário recarregar a página
    quandoEnviar.preventDefault();

    // Rodamos todas as validações
    const telefoneCerto = validarTelefone();
    const emailCerto = validarEmail();
    const cpfCerto = validarCPF();
    const dataCerto = validarDataNascimento();

    // Se TODOS estiverem corretos ✅
    if (telefoneCerto && emailCerto && cpfCerto && dataCerto) {
        alert('✅ Tudo certo! Formulário enviado com sucesso!');
    }
});

// Verifica enquanto a pessoa termina de digitar cada campo
document.getElementById('telefone').addEventListener('blur', validarTelefone);
document.getElementById('email').addEventListener('blur', validarEmail);
document.getElementById('cpf').addEventListener('blur', validarCPF);
document.getElementById('nascimento').addEventListener('blur', validarDataNascimento);
