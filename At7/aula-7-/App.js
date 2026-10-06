import React from 'react';
import {Text,View} from 'react-native';
import estilo from './src/estilos';

export default function App(){
  const tela = <View style = {estilo.Principal}>
  <Text style = {estilo.Titulo}> Diego Parracho Viana Silveira </Text>
  <Text style = {estilo.Subtitulo}> Engenharia de Computação </Text>
  <Text style = {estilo.Paragrafo}> Prazer, sou Diego. Faço parte de uma empresa de jogos indies com meus amigo, Semicollon Estudios (Instagram: @Semicollon_estudios), faço dança de salão (Forró, Bolero, Samba de Gafieira, Zouk, et cetera), e gosto bastante da franquia multiplataforma Umamusume, que retrata de personagens antropromorficas baseadas em cavalos reais do cenário de corrida japones </Text>
  <Text style = {estilo.Rodape}> "A vida só é dura pra quem é mole" - Meronha </Text>
  </View>
  return tela
}