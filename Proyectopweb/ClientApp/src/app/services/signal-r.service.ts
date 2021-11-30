import { EventEmitter, Inject, Injectable } from '@angular/core';
import { inject } from '@angular/core/testing';
import * as signalR from "@aspnet/signalr";
import { Paciente } from '../Administrador/models/Paciente';
@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  private hubConnection: signalR.HubConnection;
  signalReceived = new EventEmitter<Paciente>();
  baseUrl: string;
  constructor(@Inject('BASE_URL') baseUrl: string) {
    this.buildConnection();
    this.startConnection();
    this.baseUrl = baseUrl;

  }
  private buildConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder().withUrl(this.baseUrl + "signalHub").build();
  };
  private startConnection=()=>{
    this.hubConnection.start().then(()=>{
      console.log("Connection started");
      this.registerSginalEvents();
    }).catch(err=>{
      console.log("Error while starting connection: "+err);
      setTimeout(function(){
        this.startConnection();
      },3000);
    });
  }
  private registerSginalEvents(){
    this.hubConnection.on("SignalMessageReceived", (data: Paciente)=>{
      this.signalReceived.emit(data);
    });
  }
}
