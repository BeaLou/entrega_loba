import speech_recognition as sr
import requests

# url = 'http://localhost:5216/api/transcribe'
url = 'https://ccb9-170-81-69-234.ngrok-free.app/api/transcribe'

def reconhecer_fala():
    microfone = sr.Recognizer()
    with sr.Microphone() as source:
        microfone.adjust_for_ambient_noise(source)  # To avoid noise
        print("Diga alguma coisa: ")
        audio = microfone.listen(source)
        try:
            frase = microfone.recognize_google(audio, language="pt-BR")  # Get the phrase and transcribe
            print("Você disse: " + frase)
        except sr.UnknownValueError:
            print("Não entendi o que você quis dizer!")
            return ""

    with open('transcricao.txt', 'a', encoding="utf-8") as file:
        file.write(frase + " \n")

    return frase

def enviarPraLoba():
    with open('transcricao.txt', 'r', encoding="utf-8") as filet:
        content = filet.read()
        
        headers = {'Content-Type': 'application/json'}
        payload = {'transcricao': content, 'nome': 'teste envio', 'caminho':'teste py'}

        # Enviar a requisição POST para a API
        response = requests.post(url, headers=headers, json=payload)

        # Verificar a resposta da API
        if response.status_code == 200:
            print('Requisição enviada com sucesso!')
        else:
            print('erro, porra', response.status_code)


while True:
    fala = reconhecer_fala()
    if "parar" in fala.lower():
        break

enviarPraLoba()

