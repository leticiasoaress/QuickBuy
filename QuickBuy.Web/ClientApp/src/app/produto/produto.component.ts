import { Component } from "@angular/core";

@Component({
    selector: "app-produto",
    templateUrl: "./produto.component.html",
    styleUrls: ['./produto.component.css']
})
export class ProdutoComponent {
    nome: string;
    liberadoParaVenda: boolean;

    obterNome(): string {
        return this.nome;
    }
}
