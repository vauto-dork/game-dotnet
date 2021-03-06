import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
   selector: 'app-root',
   templateUrl: './app.component.html',
   styleUrls: ['./app.component.scss']
})

export class AppComponent implements OnInit {
   constructor(private _httpService: Http) { }
   apiValues: string[] = [];
   title = 'DorkGame';
    ngOnInit() {
       this._httpService.get('/api/player').subscribe(values => {
        this.apiValues = values.json() as string[];
       });
    }
}
