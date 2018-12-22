import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { NgZorroAntdModule, NZ_I18N, en_US } from 'ng-zorro-antd';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { NavbarComponent } from './navbar/navbar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {NoopAnimationsModule} from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { AuthService } from '../app/_services/auth.service';

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent,
      NavbarComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      NgZorroAntdModule,
      BrowserAnimationsModule,
      NoopAnimationsModule,
      FormsModule
   ],
   providers   : [ { provide: NZ_I18N, useValue: en_US }, AuthService ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
