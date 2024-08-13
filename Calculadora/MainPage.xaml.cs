namespace Calculadora
{
    public partial class MainPage : ContentPage
    {

        public MainPage() {
            InitializeComponent();
        }

        private void BTNsomarClicked(object sender, EventArgs e) {
            if (double.TryParse(Numero1entrada.Text, out double Numero1) && double.TryParse(Numero2entrada.Text, out double Numero2)) {
                double soma = Numero1 + Numero2;

                ResultLabel.Text = $"Resultado: {soma}";



            }

        }

        private void BTNsubtrairClicked(object sender, EventArgs e) {
            if (double.TryParse(Numerosubtrair1.Text, out double subtrair1) && double.TryParse(Numerosubtrair2.Text, out double subtrair2)) {
                double subtracao = subtrair1 - subtrair2;

                resultadosubtracao.Text = $"Resultado: {subtracao}";
            }
        }

        private void BTNmultiplicarCliked(object sender, EventArgs e) {
            if (double.TryParse(Numeromultiplicar1.Text, out double multiplicar1) && double.TryParse(Numeromultiplicar2.Text, out double multiplicar2)) {
                double multiplicacao = multiplicar1 * multiplicar2;

                resultadomultiplicacao.Text = $"Resultado: {multiplicacao}";
            }
        }

        private void BTNdividirCliked(object sender, EventArgs e) {
            if (double.TryParse(Numerodividir1.Text, out double dividir1) && double.TryParse(Numerodividir2.Text, out double dividir2)) {
                double divisao = dividir1 / dividir2;

                resultadodivisao.Text = $"Resultado: {divisao}";

            }
        }

    }
}
