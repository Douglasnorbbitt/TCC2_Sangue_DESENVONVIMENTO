﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCC2_Sangue.Helpers
{
    public class MensagemActionResult : ActionResult
    {
        private readonly ActionResult _actionResult;
        private readonly string _mensagem;
        private readonly TipoMensagemAlerta _tipo;

        public MensagemActionResult(ActionResult actionResult, string mensagem, TipoMensagemAlerta tipo)
        {
            _actionResult = actionResult;
            _mensagem = mensagem;
            _tipo = tipo;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            switch (_tipo)
            {
                case TipoMensagemAlerta.Sucesso:
                    context.Controller.TempData["Sucesso"] = _mensagem;
                    break;
                case TipoMensagemAlerta.Erro:
                    context.Controller.TempData["Erro"] = _mensagem;
                    break;
                case TipoMensagemAlerta.Alerta:
                    context.Controller.TempData["Alerta"] = _mensagem;
                    break;
                case TipoMensagemAlerta.Informacao:
                    context.Controller.TempData["Informacao"] = _mensagem;
                    break;
            }
            _actionResult.ExecuteResult(context);
        }

        public enum TipoMensagemAlerta
        {
            Sucesso = 1,
            Erro = 2,
            Alerta = 3,
            Informacao = 4,
        }
    }
    public static class ActionResultExtensions
    {
        public static ActionResult Sucesso(this ActionResult actionResult, string mensagem)
        {
            return new MensagemActionResult(actionResult, mensagem, MensagemActionResult.TipoMensagemAlerta.Sucesso);
        }
        public static ActionResult Erro(this ActionResult actionResult, string mensagem)
        {
            return new MensagemActionResult(actionResult, mensagem, MensagemActionResult.TipoMensagemAlerta.Erro);
        }
        public static ActionResult Alerta(this ActionResult actionResult, string mensagem)
        {
            return new MensagemActionResult(actionResult, mensagem, MensagemActionResult.TipoMensagemAlerta.Alerta);
        }
        public static ActionResult Informacao(this ActionResult actionResult, string mensagem)
        {
            return new MensagemActionResult(actionResult, mensagem, MensagemActionResult.TipoMensagemAlerta.Informacao);
        }
    }
}