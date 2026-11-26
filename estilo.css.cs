/* Isto é um comentário — o computador não lê essa linha */
/* O * significa "todos os elementos da página" */

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}

body {
    background-color: #f0f4f8; /* Cor de fundo azul bem clarinho */
    display: flex;
    justify-content: center;   /* Centraliza horizontalmente */
    align-items: center;       /* Centraliza verticalmente */
    min-height: 100vh;         /* Ocupa toda a altura da tela */
    padding: 20px;
}

.container {
    background-color: #ffffff; /* Fundo branco do formulário */
    padding: 30px;
    border-radius: 12px;       /* Cantos arredondados */
    box-shadow: 0 4px 12px rgba(0,0,0,0.1); /* Sombra suave */
    width: 100%;
    max-width: 450px;         /* Largura máxima */
}

h1 {
    text-align: center;       /* Título no centro */
    color: #2d3748;            /* Cor do texto escura */
    margin-bottom: 25px;
    font-size: 22px;
}

.grupo-campo {
    margin-bottom: 20px;      /* Espaço entre os campos */
}

label {
    display: block;
    margin-bottom: 6px;
    color: #4a5568;
    font-weight: 500;
}

input {
    width: 100%;              /* Ocupa toda a largura disponível */
    padding: 10px 12px;
    border: 2px solid #e2e8f0;
    border-radius: 6px;
    font-size: 15px;
}

/* Quando clicamos dentro do campo */
input:focus {
    outline: none;
    border-color: #3182ce;    /* Borda fica azul */
}

/* Mensagens de erro */
.erro {
    display: block;
    margin-top: 5px;
    font-size: 13px;
    color: #e53e3e;           /* Vermelho */
}

.botoes {
    display: flex;
    gap: 12px;                /* Espaço entre os botões */
    margin-top: 25px;
}

button {
    flex: 1;                  /* Divide o espaço igualmente */
    padding: 12px;
    border: none;
    border-radius: 6px;
    font-size: 15px;
    font-weight: 600;
    cursor: pointer;
}

.btn-cancelar {
    background-color: #e2e8f0;
    color: #2d3748;
}

.btn-enviar {
    background-color: #3182ce;
    color: #ffffff;
}
