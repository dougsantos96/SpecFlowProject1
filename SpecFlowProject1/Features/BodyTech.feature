Feature: BodyTech
	Caso de estudo de automação no site BodyTech

#Teste inicial
@CT001
Scenario: Acessar o site BodyTech
	Given acesso ao google
	When pesquiso pelo BodyTech
	Then site deve estar acessível