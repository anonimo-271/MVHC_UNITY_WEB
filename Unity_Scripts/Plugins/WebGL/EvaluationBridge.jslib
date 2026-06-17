/**
 * EvaluationBridge.jslib
 * Caminho no projeto Unity: Assets/Plugins/WebGL/EvaluationBridge.jslib
 *
 * Bridge entre C# e a função JavaScript abrirAvaliacao()
 * definida no index.html do build WebGL.
 */
mergeInto(LibraryManager.library, {

  AbrirAvaliacao: function () {
    if (typeof window.abrirAvaliacao === 'function') {
      window.abrirAvaliacao();
    }
  }

});
