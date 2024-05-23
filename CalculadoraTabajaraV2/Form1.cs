using System.Diagnostics;

namespace CalculadoraTabajaraV2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private Operacao OperacaoSelecionada { get; set; }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Resultados.SelectedItems.Count > 0)
        {
            var resultadoSelecionado = Resultados.SelectedItem.ToString();

            MessageBox.Show(resultadoSelecionado);
        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        OperacaoSelecionada = Operacao.Soma;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        OperacaoSelecionada = Operacao.Subtracao;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        OperacaoSelecionada = Operacao.Multiplicacao;
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
        OperacaoSelecionada = Operacao.Divisao;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        switch (OperacaoSelecionada)
        {
            case Operacao.Soma:
                Resultados.Items.Add(
                    $"{textBox1.Text} + {textBox2.Text} = {double.Parse(textBox1.Text) + double.Parse(textBox2.Text)}");
                break;
            case Operacao.Subtracao:
                Resultados.Items.Add(
                    $"{textBox1.Text} - {textBox2.Text} = {double.Parse(textBox1.Text) - double.Parse(textBox2.Text)}");
                break;
            case Operacao.Multiplicacao:
                Resultados.Items.Add(
                    $"{textBox1.Text} * {textBox2.Text} = {double.Parse(textBox1.Text) * double.Parse(textBox2.Text)}");
                break;
            case Operacao.Divisao:
                Resultados.Items.Add(
                    $"{textBox1.Text} / {textBox2.Text} = {double.Parse(textBox1.Text) / double.Parse(textBox2.Text)}");
                break;
        }

        textBox1.Text = "";
        textBox2.Text = "";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Resultados.Items.Clear();
        textBox1.Text = "";
        textBox2.Text = "";
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        var link = new ProcessStartInfo
        {
            FileName = "cmd",
            WindowStyle = ProcessWindowStyle.Hidden,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            Arguments = "/c start https://www.academiadoprogramador.net/sobre"
        };
        Process.Start(link);
    }

    private enum Operacao
    {
        Soma,
        Subtracao,
        Multiplicacao,
        Divisao
    }
}