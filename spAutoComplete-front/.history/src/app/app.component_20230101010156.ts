import { Component } from "@angular/core";
import { AutoCompleteService } from "./services/autoComplete.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  constructor(private autoCompleteService: AutoCompleteService) {}
  async searchForAutoComplete(type: string, event: any) {
    const values: string = this.autoCompleteService.matchPartial(
      type,
      event.target.value
    );
    console.log(typeof AutoCompleteService);
  }
}
