using UnityEngine;
using System.Runtime.InteropServices;

/// <summary>
/// Caminho no projeto Unity: Assets/Scripts/BotaoAvaliacao.cs
///
/// Como usar:
/// 1. Crie um UI Button no Canvas da cena principal
/// 2. Adicione este script como componente no GameObject do botão
/// 3. No evento OnClick() do Button, arraste o mesmo GameObject
///    e selecione BotaoAvaliacao > AbrirModalAvaliacao
/// 4. Faça o build WebGL normalmente — a bridge jslib cuida do resto
/// </summary>
public class BotaoAvaliacao : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void AbrirAvaliacao();
#endif

    /// <summary>
    /// Chamado pelo evento OnClick() do UI Button.
    /// Abre o modal de avaliação no HTML que hospeda o build.
    /// </summary>
    public void AbrirModalAvaliacao()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        AbrirAvaliacao();
#else
        Debug.Log("[MVHC] Modal de avaliação disponível apenas no build WebGL.");
#endif
    }
}
