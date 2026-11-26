/* Isto é um comentário — o computador não lê essa linha */
/* O * significa "todos os elementos da página" */

/* Isto é um comentário — o computador não lê essa linha */
/* O * significa "todos os elementos da página" */

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'Inter', sans-serif; /* ✅ Troquei a fonte para combinar com o Figma */
}

body {
    background-color: #2135A6; /* ✅ Azul escuro do fundo, igual ao Figma */
    display: flex;
    justify-content: center;   /* Centraliza horizontalmente */
    align-items: center;       /* Centraliza verticalmente */
    min-height: 100vh;         /* Ocupa toda a altura da tela */
    padding: 20px;
}

.container {
    background-color: #ffffff; /* Fundo branco do formulário */
    padding: 40px;             /* ✅ Mais espaço interno, igual ao design */
    border-radius: 16px;       /* ✅ Cantos um pouco mais arredondados */
    box-shadow: 0 4px 24px rgba(0,0,0,0.1); /* ✅ Sombra mais suave */
    width: 100%;
    max-width: 480px;          /* ✅ Um pouquinho mais largo */
}

h1 {
    text-align: center;       /* Título no centro */
    color: #1E293B;           /* ✅ Texto mais escuro */
    margin-bottom: 40px;      /* ✅ Espaçamento ajustado */
    font-size: 32px;          /* ✅ Tamanho mais equilibrado */
    font-weight: 700;         /* ✅ Negrito */
}

.grupo-campo {
    margin-bottom: 24px;      /* ✅ Mais espaço entre os campos */
}

label {
    display: block;
    margin-bottom: 8px;       /* ✅ Mais espaço abaixo do rótulo */
    color: #334155;           /* ✅ Cor do texto mais legível */
    font-weight: 500;
    font-size: 14px;          /* ✅ Tamanho padronizado */
}

input {
    width: 100%;              /* Ocupa toda a largura disponível */
    padding: 14px 16px;       /* ✅ Campos mais altos, mais confortável */
    border: 1px solid #CBD5E1; /* ✅ Borda mais fina e suave */
    border-radius: 8px;       /* ✅ Cantos um pouco mais arredondados */
    font-size: 15px;
    color: #334155;
}

/* Quando clicamos dentro do campo */
input:focus {
    outline: none;
    border-color: #2135A6;    /* ✅ Borda fica da mesma cor azul do fundo */
}

/* Mensagens de erro */
.erro {
    display: block;
    margin-top: 6px;
    font-size: 13px;
    color: #DC2626;            /* ✅ Vermelho mais forte para erro */
}

.botoes {
    display: flex;
    gap: 16px;                 /* ✅ Mais espaço entre os botões */
    margin-top: 32px;          /* ✅ Mais espaço acima dos botões */
}

button {
    flex: 1;                   /* Divide o espaço igualmente */
    padding: 14px;             /* ✅ Botões mais altos */
    border: none;
    border-radius: 8px;        /* ✅ Mesmo estilo dos campos */
    font-size: 16px;
    font-weight: 600;
    cursor: pointer;
    transition: filter 0.2s;   /* ✅ Efeito suave ao passar o mouse */
}

button:hover {
    filter: brightness(0.95);  /* ✅ Escurece um pouquinho ao passar o mouse */
}

.btn-cancelar {
    background-color: #F1F5F9; /* ✅ Cinza bem clarinho */
    color: #475569;            /* ✅ Texto cinza escuro */
}

.btn-enviar {
    background-color: #2135A6; /* ✅ Mesmo azul do fundo da página */
    color: #ffffff;
}

